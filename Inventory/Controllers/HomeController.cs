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
    }
}
