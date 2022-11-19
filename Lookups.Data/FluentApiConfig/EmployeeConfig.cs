using Lookups.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lookups.Data.FluentApiConfig
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(a => a.Manager).WithMany(s => s.Employees).HasForeignKey(r => r.ManagerId);
            builder.HasIndex(a => a.ManagerId);

        }
    }
}
