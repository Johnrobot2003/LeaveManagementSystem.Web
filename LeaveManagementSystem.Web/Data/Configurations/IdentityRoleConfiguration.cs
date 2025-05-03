using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Web.Data.Configurations
{
    public class IdentityRoleConfiguration: IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
            new IdentityRole
            {
                Id = "7d92f11f-4d87-4ba7-9b1e-918906386c78",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
         new IdentityRole
         {
             Id = "f9fa948a-5780-4cfd-bb53-8b3d326014af",
             Name = "Supervisor",
             NormalizedName = "SUPERVISOR"
         },
         new IdentityRole
         {
             Id = "f7023c71-325f-45af-b159-0437489f5f6f",
             Name = "Administrator",
             NormalizedName = "ADMINISTRATOR"
         }
            );
        }
    }
}
