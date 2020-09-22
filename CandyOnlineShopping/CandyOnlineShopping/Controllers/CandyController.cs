using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyOnlineShopping.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CandyOnlineShopping.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyService _candyService;
        private readonly ICategoryService _categoryService;

        public CandyController(ICandyService candyService,ICategoryService categoryService)
        {
            _candyService = candyService;
            _categoryService = categoryService;
        }
        public IActionResult List()
        {
            ViewBag.CurrentCategory = "Best Sellers!!!";
            return View(_candyService.GetAll());
        }
    }
}