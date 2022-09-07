using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdemo1.Repository;

namespace Web1.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IUnitofWork _uniofWork;

        public CategoriesController(IUnitofWork unitofWork)
        {
            _uniofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var categories = _uniofWork.CategoryBaseService.GetAll();
            return View(categories);
        }
    }
}
