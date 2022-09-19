using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdemo1.Models;
using Webdemo1.Repository;

namespace Web1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitofWork _uniofWork;

        public CategoryController(IUnitofWork unitofWork)
        {
            _uniofWork = unitofWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categories = _uniofWork.CategoryBaseService.GetAll().ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            if(id == 0)
            {
                return View();
            } else
            {
                var category = _uniofWork.CategoryBaseService.GetById(id);
                return View(category);
            }                     
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(string.IsNullOrEmpty(category.Name))
            {
                ModelState.AddModelError(string.Empty, "Khong duoc de trong");
                return View();
            } 
            else
            {
                if (category.ID == 0)
                {
                    _uniofWork.CategoryBaseService.Add(category);
                }
                else
                {
                    _uniofWork.CategoryBaseService.Update(category);
                }
                _uniofWork.Save();
                return RedirectToAction("Index", "Category");
            }           
        }        

    }
}
