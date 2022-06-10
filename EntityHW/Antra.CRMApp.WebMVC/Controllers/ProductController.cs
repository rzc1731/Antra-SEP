﻿using Microsoft.AspNetCore.Mvc;
using Antra.CRMApp.WebMVC.Models;
using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServiceAsync productServiceAsync;
        public ProductController(IProductServiceAsync prodservice)
        {
            productServiceAsync = prodservice;
        }
        public async Task<IActionResult> Index()
        {
            var Collection = await productServiceAsync.GetAllAsync();
            if (Collection != null)
            {
                return View(Collection);
            }
            List<ProductModel> model = new List<ProductModel>();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                await productServiceAsync.AddProductAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}