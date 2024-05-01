using BlazorApp1.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Model
{
    public class ToDoDbContext : DbContext
    {

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>().HasData(new List<TodoItem>
            {
                new TodoItem
                {
                    Id = 1,
                    Description = "Complete All Coded Assignments",
                    IsCompleted = false,
                    DueDate = new DateTime(2024,04,30)
                },
                new TodoItem
                {
                    Id=2,
                    Description = "Clean My Room",
                    IsCompleted = true,
                    DueDate = new DateTime(2024,04,27)
                },
                new TodoItem
                {
                    Id = 3,
                    Description = "Apartment Rent",
                    IsCompleted = false,
                    DueDate = new DateTime(2024,04,24)
                }
            });
        }
    }
}

