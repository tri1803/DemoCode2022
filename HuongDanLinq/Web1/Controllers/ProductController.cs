using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdemo1.Repository;

namespace Web1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitofWork _uniofWork;

        public ProductController(IUnitofWork unitofWork)
        {
            _uniofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var listProducts = _uniofWork.ProductBaseService.ObjectContext.Include(s => s.Category).AsEnumerable();
            return View(listProducts);
        }

        public IActionResult Save(int id)
        {
            var categories = _uniofWork.CategoryBaseService.GetAll();
            var product = _uniofWork.ProductBaseService.GetById(id);
            //product.Category
            return View();
        }
    }
}
