using Common.StandardInfrastructure;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookups.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<GetEmployeeDto>> GetAll();
        Task<PagedListDto<GetEmployeeDto>> GetAllPaged(EmployeeFilterDto filteringDto, PagingSortingDto pagingSortingDto);
        Task<GetEmployeeDto> Get(Guid id);
        Task<string> Add(AddUpdateEmployeeDto EmployeeDto);
        Task<string> Update(AddUpdateEmployeeDto EmployeeDto);
        Task<string> Delete(Guid id);
    }
}
