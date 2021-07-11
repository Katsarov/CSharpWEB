


namespace WebAppMVC.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using System.Collections.Generic;
    using WebAppMVC.Filters;
    using WebAppMVC.Models;
    using WebAppMVC.Services;

    public class CatsController : Controller
    {
        // /Cats/All
        private readonly ICatService catService;
        private readonly CatConfiguration catConfiguration;


        public CatsController(ICatService catService, IOptions<CatConfiguration> catConfiguration)
        {
            this.catService = catService;
            this.catConfiguration = catConfiguration.Value;
        }

        public IActionResult AllCatsHere()
        {
            if (this.catService.SomeValue == null)
            {
                this.catService.SomeValue = "Sharo";
            }

            var catNames = this.catService.GetCatNames();

            var numberOfCats = this.catConfiguration.NumberOfCats;

            return View(new CatViewModel { Name = "Sharo" });
        }

        [AddHeader(Name = "My-Header", Value = "My-Header-Value")]
        public IActionResult All()
        {
            var cats = new List<CatViewModel>
            {
                new CatViewModel {Name = "Sharo", Age = 5},
                new CatViewModel {Name = "Lady", Age = 13}
            };

            return View(cats);
        }

        public IActionResult Create() => View();


        [HttpPost]
        public IActionResult Create(CatFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //return Ok();

            return Redirect("/Cats/All");

        }


        //public IActionResult Add()
        //{
        //    ViewBag.Name = "My name is Kalin";

        //    return View();
        //}

        public IActionResult Add()
        {
            //return View(new CatViewModel { Name = "I am Kalin" });

            return View();
        }

        public IActionResult Crown() => View();

        [HttpPost]
        public IActionResult Crown(CatViewModel model) => Ok(model);

        public IActionResult Many()
        {
            var cats = new List<CatViewModel>
            {
                new CatViewModel {Name = "Sharo", Age = 5},
                new CatViewModel {Name = "Lady", Age = 13}
            };

            return View(cats);
        }

        

    }
}
