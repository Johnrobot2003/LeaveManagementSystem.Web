using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<LeaveType> LeaveTypes{ get; set; }
    public DbSet<DogBreeds> DogBreeds { get; set; }

public DbSet<LeaveManagementSystem.Web.Models.LeaveTypes.ArchivesLeaveType> ArchivesLeaveType { get; set; } = default!;
}

