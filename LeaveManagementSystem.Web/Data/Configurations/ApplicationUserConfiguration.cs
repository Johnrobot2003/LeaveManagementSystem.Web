using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Web.Data.Configurations
{
    public class ApplicationUserConfiguration: IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                Email = "adminemail@user.com",
                NormalizedEmail = "ADMINEMAIL@USER.COM",
                NormalizedUserName = "ADMINEMAIL@USER.COM",
                UserName = "adminemail@user.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(2003, 01, 23)
            },
            new ApplicationUser
            {
                Id = "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                Email = "secondadmin@user.com",
                NormalizedEmail = "SECONDADMIN@USER.COM",
                NormalizedUserName = "SECONDADMIN@USER.COM",
                UserName = "secondadmin@user.com",
                PasswordHash = hasher.HashPassword(null, "Ro#an2003"),
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Admin3",
                DateOfBirth = new DateOnly(2003, 01, 23)
            },
             new ApplicationUser
             {
                 Id = "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                 Email = "acebojohnrohan@gmail.com",
                 NormalizedEmail = "ACEBOJOHNROHAN@GMAIL.COM",
                 NormalizedUserName = "ACEBOJOHNROHAN@GMAIL.COM",
                 UserName = "acebojohnrohan@gmail.com",
                 PasswordHash = hasher.HashPassword(null, "Adminp@ssword"),
                 EmailConfirmed = true,
                 FirstName = "John",
                 LastName = "Acebo",
                 DateOfBirth = new DateOnly(2003, 01, 23)
             }

           );
        }
    }
}
