﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;

namespace LeaveManagementSystem.Web.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<LeaveType> LeaveTypes{ get; set; }
    public DbSet<DogBreeds> DogBreeds { get; set; }
}

