using AutoMapper;
using Common.StandardInfrastructure;
using Lookups.Data.Entities;
using Lookups.DataAccess;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using Lookups.Service.Interfaces;
using Lookups.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Lookups.Service.Services
{
    public class EmployeeLogService : BaseServices, IEmployeeLogService
    {
        public EmployeeLogService(IMapper mapper, IUnitOfWork unitOfWork, IStringLocalizer<Service.Resources.Lookups> lookupsLocalize
            , IStringLocalizer<Common.StandardInfrastructure.Resources.Common> commonLocalize)
             : base(mapper, unitOfWork, lookupsLocalize, commonLocalize)
        {
        }

        public async Task<IEnumerable<GetEmployeeLogDto>> GetAll()
        {
            var list = (await UnitOfWork.GetRepository<EmployeeLog>().GetAllAsync(
                         include: a => a.Include(r => r.Employee),
                         orderBy: obj => obj.OrderByDescending(d => d.DayDate).ThenByDescending(d => d.SignInTime)
                        ));
            return Mapper.Map<IEnumerable<GetEmployeeLogDto>>(list);
        }

        public async Task<PagedListDto<GetEmployeeLogDto>> GetAllPaged(EmployeeLogFilterDto filteringDto, PagingSortingDto pagingSortingDto)
        {
            ExpressionStarter<EmployeeLog> predicate = GetEmployeeLogPredicte(filteringDto);
            var (list, count) = await UnitOfWork.GetRepository<EmployeeLog>().GetPagedListAsync(
                predicate,
                pagingSortingDto,
                include: a => a.Include(r => r.Employee));
            return new PagedListDto<GetEmployeeLogDto>() { List = Mapper.Map<List<GetEmployeeLogDto>>(list), Count = count };
        }

        private static ExpressionStarter<EmployeeLog> GetEmployeeLogPredicte(EmployeeLogFilterDto filteringDto)
        {
            var predicate = PredicateBuilder.New(Helper.GetPredicate<EmployeeLog, EmployeeLogFilterDto>(filteringDto));
            if (!string.IsNullOrWhiteSpace(filteringDto.EmployeeNameFl?.Name))
            {
                var isContain = filteringDto.EmployeeNameFl.IsContain;
                var filterName = filteringDto.EmployeeNameFl.Name.ToLower();

                if (isContain == (int)Filter_GridEnum.Contains)
                {
                    predicate = predicate.And(p => p.Employee.NameFl.ToLower().Contains(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.StartWith)
                {
                    predicate = predicate.And(p => p.Employee.NameFl.ToLower().StartsWith(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.EndWith)
                {
                    predicate = predicate.And(p => p.Employee.NameFl.ToLower().EndsWith(filterName));
                }
            }
            else if (!string.IsNullOrWhiteSpace(filteringDto.EmployeeNameSl?.Name))
            {
                var isContain = filteringDto.EmployeeNameSl.IsContain;
                var filterName = filteringDto.EmployeeNameSl.Name.ToLower();

                if (isContain == (int)Filter_GridEnum.Contains)
                {
                    predicate = predicate.And(p => p.Employee.NameSl.ToLower().Contains(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.StartWith)
                {
                    predicate = predicate.And(p => p.Employee.NameSl.ToLower().StartsWith(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.EndWith)
                {
                    predicate = predicate.And(p => p.Employee.NameSl.ToLower().EndsWith(filterName));
                }
            }
            else if (!string.IsNullOrWhiteSpace(filteringDto.EmployeeCode?.Name))
            {
                var isContain = filteringDto.EmployeeCode.IsContain;
                var filterName = filteringDto.EmployeeCode.Name.ToLower();

                if (isContain == (int)Filter_GridEnum.Contains)
                {
                    predicate = predicate.And(p => p.Employee.Code.ToLower().Contains(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.StartWith)
                {
                    predicate = predicate.And(p => p.Employee.Code.ToLower().StartsWith(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.EndWith)
                {
                    predicate = predicate.And(p => p.Employee.Code.ToLower().EndsWith(filterName));
                }
            }
            return predicate;
        }

        public async Task<GetEmployeeLogDto> Get(Guid id)
        {
            var employeeLog = await UnitOfWork.GetRepository<EmployeeLog>().GetAsync(id);
            return Mapper.Map<EmployeeLog, GetEmployeeLogDto>(employeeLog);
        }

        public async Task<string> Add(AddEmployeeLogDto employeeLogDto)
        {
            if (IsLogExistForDay(employeeLogDto as UpdateEmployeeLogDto).Result)
            {
                return LookupsLocalize["EmployeeLogService_IsExists"];
            }
            else
            {

                var employeeLog = new EmployeeLog(
                    employeeLogDto.EmployeeId, 
                    employeeLogDto.DayDate, 
                    employeeLogDto.SignInTime,
                    employeeLogDto.SignOutTime
                    );
                    //Mapper.Map<AddUpdateEmployeeLogDto, EmployeeLog>(employeeLogDto);
                await UnitOfWork.GetRepository<EmployeeLog>().AddAsync(employeeLog);
                await UnitOfWork.SaveChangesAsync();
                return null;
            }
        }

        private async Task<bool> IsLogExistForDay(UpdateEmployeeLogDto logDto)
        {
            return await UnitOfWork.GetRepository<EmployeeLog>().IsExistAnyAsync(a => 
            a.EmployeeId == logDto.EmployeeId 
            && a.DayDate.Date == logDto.DayDate.Date
            && a.Id != logDto.Id
            );
        }

        public async Task<string> Update(UpdateEmployeeLogDto employeeLogDto)
        {
            if (await UnitOfWork.GetRepository<EmployeeLog>().IsExistAsync(employeeLogDto))
            {
                return LookupsLocalize["EmployeeLogService_IsExists"];
            }
            else
            {
    
                var employeeLogOld =await UnitOfWork.GetRepository<EmployeeLog>().GetAsync(employeeLogDto.Id);
                var employeeLogNew = new EmployeeLog().Update(
                                        employeeLogDto.Id,
                                        employeeLogDto.EmployeeId,
                                        employeeLogDto.DayDate,
                                        employeeLogDto.SignInTime,
                                        employeeLogDto.SignOutTime);
                //var employeeLogNew = Mapper.Map<EmployeeLog>(employeeLogDto);
                await UnitOfWork.GetRepository<EmployeeLog>().UpdateAsync(employeeLogNew, employeeLogOld);
                await UnitOfWork.SaveChangesAsync();
                return null;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            var employeeLog = await UnitOfWork.GetRepository<EmployeeLog>().GetAsync(id);
            if (employeeLog == null) return null;
            await UnitOfWork.GetRepository<EmployeeLog>().RemoveAsync(employeeLog);
            await UnitOfWork.SaveChangesAsync();
            return null;
        }

    }
}
