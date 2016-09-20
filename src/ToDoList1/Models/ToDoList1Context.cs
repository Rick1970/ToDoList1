using Microsoft.EntityFrameworkCore;

namespace ToDoList1.Models
{
    public class ToDoList1Context : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDoList1;integrated security=True");
        }
    }
}