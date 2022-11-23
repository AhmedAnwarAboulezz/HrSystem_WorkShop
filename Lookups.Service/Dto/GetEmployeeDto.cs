using System;
using Lookups.Service.Dto.Base;
using System.ComponentModel.DataAnnotations;
using Common.StandardInfrastructure;

namespace Lookups.Service.Dto
{
    public class GetEmployeeDto: BaseDto
    {
        public string Code { get; set; }
        public string NameFl { get; set; }
        public string NameSl { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryNameFl { get; set; }
        public string CountryNameSl { get; set; }
        public Guid? GenderId { get; set; }
        public string GenderNameFl { get; set; }
        public string GenderNameSl { get; set; }
        public Guid? ManagerId { get; set; }
        public string ManagerNameFl { get; set; }
        public string ManagerNameSl { get; set; }
    }



    public class EmployeeDropDownRequestDto
    {
        public string Value { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public Guid? EmployeeId { get; set; }
        public bool FirstCall { get; set; }
    }

    public class EmployeeDropDownDto : DropDownDto
    {
        public string FullNameFl => $"{Code} - {NameFl}";
        public string FullNameSl => $"{Code} - {NameSl}";
    }
}
