using Common.StandardInfrastructure;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookups.Service.Interfaces
{
    public interface IEmployeeLogService
    {
        Task<GetEmployeeLogDto> Get(Guid id);
        Task<IEnumerable<GetEmployeeLogDto>> GetAll();
        Task<string> Add(AddEmployeeLogDto EmployeeDto);
        Task<string> Update(UpdateEmployeeLogDto EmployeeDto);
        Task<string> Delete(Guid id);
    }
}
