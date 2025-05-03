using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Web.Data.Configurations
{
    public class IdentityUserRoleConfiguration:IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
         new IdentityUserRole<string>
         {
             RoleId = "f7023c71-325f-45af-b159-0437489f5f6f",
             UserId = "1bdeca61-b213-4a07-9321-d80f8d442ba4"
         },
         new IdentityUserRole<string>
         {
             RoleId = "f7023c71-325f-45af-b159-0437489f5f6f",
             UserId = "e6a8f81b-851a-4c8d-80df-dbb02c481971"
         },
          new IdentityUserRole<string>
          {
              RoleId = "f7023c71-325f-45af-b159-0437489f5f6f",
              UserId = "3d03a090-0365-4bd6-a372-0c0cca6b2ec5"
          }
         );
        }
    }
}
