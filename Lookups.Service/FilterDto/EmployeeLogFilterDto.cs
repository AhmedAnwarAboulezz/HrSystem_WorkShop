using Common.StandardInfrastructure.CommonDto;
using System;


namespace Lookups.Service.FilterDto
{
    public class EmployeeLogFilterDto
    {
        public DynamicFilterDto<string> EmployeeCode { get; set; }
        public DynamicFilterDto<string> EmployeeNameFl { get; set; }
        public DynamicFilterDto<string> EmployeeNameSl { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan SignInTime { get; set; }
        public TimeSpan? SignOutTime { get; set; }
    }
}
