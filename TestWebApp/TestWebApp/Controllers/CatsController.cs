
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestWebApp.Data;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class CatsController : Controller
    {
        private readonly DbContext data;

        public CatsController() 
            => this.data = new DbContext();

        public IActionResult List()
        {
            var cats = this.data
                .AllCats()
                .Select(c => new CatModel
                {
                    Name = c.Name,
                    Age = c.Age,
                    Owner = c.Owner.Name
                })
                .ToList();

            if (!cats.Any())
            {
                return NotFound();
            }

            return View(cats);
        }

        public IActionResult Search()
        {
            return View();
            //return Redirect("http://softuni.bg");
        }

        public IActionResult Toto()
        {
            //return View();
            return Redirect("http://softuni.bg");
        }
    }
}
