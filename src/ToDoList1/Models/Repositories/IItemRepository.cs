using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList1.Models;

namespace ToDoList1.Models
{
    public interface IItemRepository
    {
        IQueryable<Item> Items { get; }
        Item Save(Item item);
        Item Edit(Item item);
        void Remove(Item item);
    }
}