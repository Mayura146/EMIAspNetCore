using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyOnlineShopping.Models.Services.Interfaces;
using CandyOnlineShopping.Models.ViewModels;
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

            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.CurrentCategory = "Best Sellers!!";
            candyListViewModel.Candies = _candyService.GetAll();
            //ViewBag.CurrentCategory = "Best Sellers!!!";
            //return View(_candyService.GetAll());
            return View(candyListViewModel);
        }
    }
}