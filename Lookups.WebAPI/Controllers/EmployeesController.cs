using Common.StandardInfrastructure;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using Lookups.Service.Interfaces;
using Lookups.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Lookups.WebAPI.Controllers
{
    /// <inheritdoc />
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        /// <inheritdoc />
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        /// <summary>
        /// Get data paged 
        /// </summary>
        /// <param name="filteringDto"> Search filter</param>
        /// <param name="pagingSortingDto">Sort Parameters</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetAllPaged([FromBody] EmployeeFilterDto filteringDto, [FromQuery] PagingSortingDto pagingSortingDto)
        {
            var result = await _employeeService.GetAllPaged(filteringDto, pagingSortingDto);
            return Ok(result);
        }

        /// <summary>
        /// Get Employee Dropdown List Paged
        /// </summary>
        /// <param name="filterDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetDropdownList(EmployeeDropDownRequestDto filterDto)
        {
            var result = await _employeeService.GetDropdownList(filterDto);
            return Ok(result);
        }

        /// <summary>
        /// Get all data 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _employeeService.GetAll();
            return Ok(list);
        }
        /// <summary>
        /// Get data by Id
        /// </summary>
        /// <param name="id">PK Column Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var employee = await _employeeService.Get(id);

            return Ok(employee);
        }
        /// <summary>
        /// Insert new
        /// </summary>
        /// <param name="employeeDto">Inserted object</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(AddUpdateEmployeeDto employeeDto)
        {
            var message = await _employeeService.Add(employeeDto);
            if (!string.IsNullOrWhiteSpace(message))
            {
                return BadRequest(message);
            }
            return Ok();
        }
        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="employeeDto">Updated Object</param>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> Update(AddUpdateEmployeeDto employeeDto)
        {
            var message = await _employeeService.Update(employeeDto);
            if (!string.IsNullOrWhiteSpace(message))
            {
                return BadRequest(message);
            }
            return Ok();

        }
        /// <summary>
        /// Delete data by Id
        /// </summary>
        /// <param name="id">PK Column Id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var message = await _employeeService.Delete(id);
            if (!string.IsNullOrWhiteSpace(message))
            {
                return BadRequest(message);
            }
            return Ok();
        }

    }

}
