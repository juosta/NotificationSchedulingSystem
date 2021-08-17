using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Notificationschedulingsystem.Models;
using System;
using System.Linq;

namespace ExpensesApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Notification> Notification { get; set; }
    }
}
