using System;
using Lookups.Service.Dto.Base;
using System.ComponentModel.DataAnnotations;

namespace Lookups.Service.Dto
{
    public class GetEmployeeLogDto: BaseDto
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeNameFl { get; set; }
        public string EmployeeNameSl { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan SignInTime { get; set; }
        public TimeSpan? SignOutTime { get; set; }
        public int WorkingMinutes { get; set; }
    }
}
