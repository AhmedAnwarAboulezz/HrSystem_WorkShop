using Common.StandardInfrastructure.CommonDto;
using System;
using System.Collections.Generic;

namespace Lookups.Service.FilterDto
{
    public class EmployeeFilterDto
    {
        public DynamicFilterDto<string> Code { get; set; }
        public DynamicFilterDto<string> NameFl { get; set; }
        public DynamicFilterDto<string> NameSl { get; set; }
        public DateTime? BirthDate { get; set; }
        public DynamicFilterDto<string> Address { get; set; }
        public DynamicFilterDto<string> Email { get; set; }
        public DynamicFilterDto<string> PhoneNumber { get; set; }
        public List<Guid?> CountryIds { get; set; }
        public List<Guid?> GenderIds { get; set; }
        public DynamicFilterDto<string> ManagerNameFl { get; set; }
        public DynamicFilterDto<string> ManagerNameSl { get; set; }
    }
}
