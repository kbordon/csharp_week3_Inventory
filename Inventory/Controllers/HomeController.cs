using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Inventory.Models;

namespace Inventory.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/items/new")]
      public ActionResult Inventory()
      {
        Item newItem = new Item(Request.Form["item-name"]);
        newItem.Save();
        List<Item> allItems = Item.GetAll();
        return View(allItems);
      }

      [HttpPost("/items/clear")]
      public ActionResult InventoryClear()
      {
        Item.DeleteAll();
        return View();
      }
    }
}
