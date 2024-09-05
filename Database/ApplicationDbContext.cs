using dotnet_interview.Models;
using Microsoft.EntityFrameworkCore;

namespace autoChecker.Database 
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users {get; set;}
        public DbSet<TaskItem> Tasks {get; set;}
    }
}