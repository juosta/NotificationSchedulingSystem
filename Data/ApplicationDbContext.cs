using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Notificationschedulingsystem.Models;
using System;
using System.Linq;

namespace Notificationschedulingsystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
