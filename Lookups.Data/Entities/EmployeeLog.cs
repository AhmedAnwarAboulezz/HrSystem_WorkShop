using Lookups.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace Lookups.Data.Entities
{
  public  class EmployeeLog :BaseModel
    {
        public Guid EmployeeId { get; set; }
        public DateTime DayDate { get; set; }
        public TimeSpan SignInTime { get; set; }
        public TimeSpan? SignOutTime { get; set; }
        public int WorkingMinutes { get; set; }

        public EmployeeLog Create(Guid employeeId, DateTime dayDate, TimeSpan signIn, TimeSpan? signOut)
        {
            this.EmployeeId = employeeId;
            this.DayDate = dayDate;
            this.SignInTime = signIn;
            this.SignOutTime = signOut;
            SetEmployeeWorkingMinutes();
            return this;
            //this.WorkingMinutes = this.SignOutTime == null ? 0 : (int)this.SignOutTime.Value.Subtract(this.SignInTime).TotalMinutes;
        }

        public EmployeeLog Update(Guid id,Guid employeeId, DateTime dayDate, TimeSpan signIn, TimeSpan? signOut)
        {
            this.Id = id;
            this.EmployeeId = employeeId;
            this.DayDate = dayDate;
            this.SignInTime = signIn;
            this.SignOutTime = signOut;
            SetEmployeeWorkingMinutes();
            return this;
        }
        public void SetEmployeeWorkingMinutes()
        {
            this.WorkingMinutes = this.SignOutTime == null ? 0 : (int)this.SignOutTime.Value.Subtract(this.SignInTime).TotalMinutes;
        }
    }
}
