using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Content.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: Category
        public PartialViewResult List(int category=0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(_categoryService.GetAll());
        }
    }
}