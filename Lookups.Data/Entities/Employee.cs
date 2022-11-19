using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lookups.Data.Entities.Base;

namespace Lookups.Data.Entities
{
    public class Employee : BaseModel
    {
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(200)]
        public string NameFl { get; set; }
        [StringLength(200)]
        public string NameSl { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? CountryId { get; set; }
        public Country Country { get; set; }
        public Guid? GenderId { get; set; }
        public Gender Gender { get; set; }
        public Guid? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
