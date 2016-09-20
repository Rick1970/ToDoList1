﻿using Microsoft.AspNetCore.Mvc;
using ToDoList1.Models;
using System.Linq;




namespace ToDoList1.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoList1Context db = new ToDoList1Context();
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }
    }

}