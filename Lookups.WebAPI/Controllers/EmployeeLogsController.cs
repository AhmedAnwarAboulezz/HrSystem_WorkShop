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
    public class EmployeeLogsController : BaseController
    {
        private readonly IEmployeeLogService _employeeLogService;
        /// <inheritdoc />
        public EmployeeLogsController(IEmployeeLogService employeeLogService)
        {
            _employeeLogService = employeeLogService;
        }

        /// <summary>
        /// Get all data 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _employeeLogService.GetAll();
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
            var employeeLog = await _employeeLogService.Get(id);

            return Ok(employeeLog);
        }
        /// <summary>
        /// Insert new
        /// </summary>
        /// <param name="employeeLogDto">Inserted object</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeLogDto employeeLogDto)
        {
            var message = await _employeeLogService.Add(employeeLogDto);
            if (!string.IsNullOrWhiteSpace(message))
            {
                return BadRequest(message);
            }
            return Ok();
        }
        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="employeeLogDto">Updated Object</param>
        /// <returns></returns>
        [HttpPut()]
        public async Task<IActionResult> Update(UpdateEmployeeLogDto employeeLogDto)
        {
            var message = await _employeeLogService.Update(employeeLogDto);
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
            var message = await _employeeLogService.Delete(id);
            if (!string.IsNullOrWhiteSpace(message))
            {
                return BadRequest(message);
            }
            return Ok();
        }

    }

}
