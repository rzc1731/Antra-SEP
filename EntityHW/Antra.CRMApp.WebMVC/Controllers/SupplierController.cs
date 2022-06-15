using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierServiceAsync supplierServiceAsync;
        private readonly IRegionServiceAsync regionServiceAsync;
        public SupplierController(ISupplierServiceAsync supservice, IRegionServiceAsync reg)
        {
            supplierServiceAsync = supservice;
            regionServiceAsync = reg;
        }
        public async Task<IActionResult> Index()
        {
            var Collection = await supplierServiceAsync.GetAllAsync();
            if (Collection != null)
            {
                return View(Collection);
            }
            List<SupplierModel> model = new List<SupplierModel>();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SupplierModel model)
        {
            if (ModelState.IsValid)
            {
                await supplierServiceAsync.AddSupplierAsync(model);
                return RedirectToAction("Index");
            }
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var supModel = await supplierServiceAsync.GetSupplierForEditAsync(id);
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            return View(supModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SupplierModel model)
        {
            ViewBag.IsEdit = false;
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            if (ModelState.IsValid)
            {
                await supplierServiceAsync.UpdateSupplierAsync(model);
                ViewBag.IsEdit = true;

            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await supplierServiceAsync.DeleteSupplierAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Info(int id)
        {
            var supModel = await supplierServiceAsync.GetByIdAsync(id);
            var region = await regionServiceAsync.GetByIdAsync(supModel.RegionId);
            supModel.Region = region;
            return View(supModel);
        }

        [NonAction]
        public void Demo()
        {
        }
    }
}
