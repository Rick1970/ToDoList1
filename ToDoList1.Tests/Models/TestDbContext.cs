using Microsoft.EntityFrameworkCore;

namespace ToDoList1.Models
{
    public class TestDbContext : ToDoList1Context
    {
        public override DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoList1Test;integrated security = True");
        }
    }
}