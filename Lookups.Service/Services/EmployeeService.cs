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
    public class EmployeeService : BaseServices, IEmployeeService
    {
        public EmployeeService(IMapper mapper, IUnitOfWork unitOfWork, IStringLocalizer<Service.Resources.Lookups> lookupsLocalize
            , IStringLocalizer<Common.StandardInfrastructure.Resources.Common> commonLocalize)
             : base(mapper, unitOfWork, lookupsLocalize, commonLocalize)
        {
        }

        public async Task<IEnumerable<GetEmployeeDto>> GetAll()
        {
            var list = await UnitOfWork.GetRepository<Employee>().GetAllAsync();
            return Mapper.Map<IEnumerable<Employee>, IEnumerable<GetEmployeeDto>>(list);
        }

        public async Task<PagedListDto<GetEmployeeDto>> GetAllPaged(EmployeeFilterDto filteringDto, PagingSortingDto pagingSortingDto)
        {
            ExpressionStarter<Employee> predicate = GetEmployeePredicte(filteringDto);
            var (list, count) = await UnitOfWork.GetRepository<Employee>().GetPagedListAsync(
                predicate, 
                pagingSortingDto, 
                include: a=>a.Include(r=>r.Manager).Include(r=>r.Country).Include(r=> r.Gender));
            return new PagedListDto<GetEmployeeDto>() { List = Mapper.Map<List<GetEmployeeDto>>(list), Count = count };
        }

        public async Task<PagedListDto<EmployeeDropDownDto>> GetDropdownList(EmployeeDropDownRequestDto filterDto)
        {
            PagingSortingDto pagingSorting;
            ExpressionStarter<Employee> predicate;
            GetDropdownPredicate(filterDto, out pagingSorting, out predicate);
            var (list, count) = await UnitOfWork.GetRepository<Employee>().GetPagedListAsync(
            predicate,
            pagingSorting
            );
            return new PagedListDto<EmployeeDropDownDto>() { List = Mapper.Map<List<EmployeeDropDownDto>>(list), Count = count };
        }

        private static void GetDropdownPredicate(EmployeeDropDownRequestDto filterDto, out PagingSortingDto pagingSorting, out ExpressionStarter<Employee> predicate)
        {
            pagingSorting = new PagingSortingDto()
            {
                Limit = filterDto.Limit,
                Offset = filterDto.Offset
            };
            predicate = PredicateBuilder.New<Employee>(true);
            if (filterDto.EmployeeId.HasValue && filterDto.EmployeeId != Guid.Empty) predicate = predicate.And(a => a.Id == filterDto.EmployeeId);
            else if(!string.IsNullOrWhiteSpace(filterDto.Value))
            {
                predicate = predicate.And(a => a.NameFl.Contains(filterDto.Value) || a.NameSl.Contains(filterDto.Value) || a.Code.Contains(filterDto.Value));
            }
        }

        private static ExpressionStarter<Employee> GetEmployeePredicte(EmployeeFilterDto filteringDto)
        {
            var predicate = PredicateBuilder.New(Helper.GetPredicate<Employee, EmployeeFilterDto>(filteringDto));
            if(filteringDto.CountryIds.Any()) predicate = predicate.And(p => filteringDto.CountryIds.Contains(p.CountryId));
            if (filteringDto.GenderIds.Any()) predicate = predicate.And(p => filteringDto.GenderIds.Contains(p.GenderId));
            if (!string.IsNullOrWhiteSpace(filteringDto.ManagerNameFl?.Name))
            {
                var isContain = filteringDto.ManagerNameFl.IsContain;
                var filterName = filteringDto.ManagerNameFl.Name.ToLower();

                if (isContain == (int)Filter_GridEnum.Contains)
                {
                    predicate = predicate.And(p => p.Manager.NameFl.ToLower().Contains(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.StartWith)
                {
                    predicate = predicate.And(p => p.Manager.NameFl.ToLower().StartsWith(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.EndWith)
                {
                    predicate = predicate.And(p => p.Manager.NameFl.ToLower().EndsWith(filterName));
                }
            }
            else if (!string.IsNullOrWhiteSpace(filteringDto.ManagerNameSl?.Name))
            {
                var isContain = filteringDto.ManagerNameSl.IsContain;
                var filterName = filteringDto.ManagerNameSl.Name.ToLower();

                if (isContain == (int)Filter_GridEnum.Contains)
                {
                    predicate = predicate.And(p => p.Manager.NameSl.ToLower().Contains(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.StartWith)
                {
                    predicate = predicate.And(p => p.Manager.NameSl.ToLower().StartsWith(filterName));
                }
                else if (isContain == (int)Filter_GridEnum.EndWith)
                {
                    predicate = predicate.And(p => p.Manager.NameSl.ToLower().EndsWith(filterName));
                }
            }
            return predicate;
        }

        public async Task<GetEmployeeDto> Get(Guid id)
        {
            var employee = await UnitOfWork.GetRepository<Employee>().GetAsync(id);
            return Mapper.Map<Employee, GetEmployeeDto>(employee);
        }

        public async Task<string> Add(AddUpdateEmployeeDto employeeDto)
        {
            if (await UnitOfWork.GetRepository<Employee>().IsExistAsync(employeeDto))
            {
                return LookupsLocalize["EmployeeService_IsExists"];
            }
            else
            {
                var employee = Mapper.Map<AddUpdateEmployeeDto, Employee>(employeeDto);
                await UnitOfWork.GetRepository<Employee>().AddAsync(employee);
                await UnitOfWork.SaveChangesAsync();
                return null;
            }
        }

        public async Task<string> Update(AddUpdateEmployeeDto employeeDto)
        {
            if (await UnitOfWork.GetRepository<Employee>().IsExistAsync(employeeDto))
            {
                return LookupsLocalize["EmployeeService_IsExists"];
            }
            else
            {
                var employeeOld =await UnitOfWork.GetRepository<Employee>().GetAsync(employeeDto.Id);
                var employeeNew = Mapper.Map<Employee>(employeeDto);
                await UnitOfWork.GetRepository<Employee>().UpdateAsync(employeeNew, employeeOld);
                await UnitOfWork.SaveChangesAsync();
                return null;
            }
        }

        public async Task<string> Delete(Guid id)
        {
            var employee = await UnitOfWork.GetRepository<Employee>().GetAsync(id);
            if (employee == null) return null;
            await UnitOfWork.GetRepository<Employee>().RemoveAsync(employee);
            await UnitOfWork.SaveChangesAsync();
            return null;
        }

    }
}
