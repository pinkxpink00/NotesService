using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Models;

namespace ToDoList.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<TaskModel> Tasks { get; set; }
}