using System;
using Lookups.Service.Dto.Base;
using System.ComponentModel.DataAnnotations;

namespace Lookups.Service.Dto
{
    public class AddEmployeeLogDto
    {
        public Guid EmployeeId { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan SignInTime { get; set; }
        public TimeSpan? SignOutTime { get; set; }

    }

    public class UpdateEmployeeLogDto : AddEmployeeLogDto
    {
        public Guid Id { get; set; }

    }
}
