using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>().HasData
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
        var hasher = new PasswordHasher<ApplicationUser>();
        builder.Entity<ApplicationUser>().HasData(
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
             }
             
            );
        builder.Entity<IdentityUserRole<string>>().HasData(
         new IdentityUserRole<string>
         {
             RoleId = "f7023c71-325f-45af-b159-0437489f5f6f",
             UserId = "1bdeca61-b213-4a07-9321-d80f8d442ba4"
         },
         new IdentityUserRole<string>
         {
             RoleId = "f7023c71-325f-45af-b159-0437489f5f6f",
             UserId = "e6a8f81b-851a-4c8d-80df-dbb02c481971"
         }
         );

    }

    public DbSet<LeaveType> LeaveTypes{ get; set; }
    public DbSet<DogBreeds> DogBreeds { get; set; }
}

