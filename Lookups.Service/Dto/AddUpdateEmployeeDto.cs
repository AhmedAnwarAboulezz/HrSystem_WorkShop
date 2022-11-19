using System;
using Lookups.Service.Dto.Base;
using System.ComponentModel.DataAnnotations;

namespace Lookups.Service.Dto
{
    public class AddUpdateEmployeeDto: BaseDto
    {
        [StringLength(maximumLength: 10, ErrorMessageResourceName = "EmployeeDto_Code_Length", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string Code { get; set; }
        [StringLength(maximumLength: 200, ErrorMessageResourceName = "CountryDto_NameFl_Length", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string NameFl { get; set; }
        [StringLength(maximumLength: 200, ErrorMessageResourceName = "CountryDto_NameSl_Length", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string NameSl { get; set; }
        [StringLength(maximumLength: 200, ErrorMessageResourceName = "CountryDto_NameSl_Length", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        [EmailAddress(ErrorMessageResourceName = "EmployeeDto_Email_Format", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string Email { get; set; }
        [Phone(ErrorMessageResourceName = "EmployeeDto_Phone", ErrorMessageResourceType = typeof(Resources.Lookups))]
        public string PhoneNumber { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? ManagerId { get; set; }

    }
}
