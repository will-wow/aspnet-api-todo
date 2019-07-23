using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
  public class TodoContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Port=5435;Database=todo_net;Username=postgres;Password=postgres");

    public DbSet<TodoItem> TodoItems { get; set; }
  }
}