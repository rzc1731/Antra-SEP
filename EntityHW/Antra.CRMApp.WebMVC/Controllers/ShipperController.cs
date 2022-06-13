﻿using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperServiceAsync shipperServiceAsync;
        public ShipperController(IShipperServiceAsync ser)
        {
            shipperServiceAsync = ser;
        }
        public async Task<IActionResult> Index()
        {
            var result = await shipperServiceAsync.GetAllAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShipperModel model)
        {
            if (ModelState.IsValid)
            {
                await shipperServiceAsync.AddShipperAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var empModel = await shipperServiceAsync.GetShipperForEditAsync(id);
            return View(empModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ShipperModel model)
        {
            ViewBag.IsEdit = false;
            if (ModelState.IsValid)
            {
                await shipperServiceAsync.UpdateShipperAsync(model);
                ViewBag.IsEdit = true;

            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await shipperServiceAsync.DeleteShipperAsync(id);
            return RedirectToAction("Index");
        }

        [NonAction]
        public void Demo()
        {
        }
    }
}
