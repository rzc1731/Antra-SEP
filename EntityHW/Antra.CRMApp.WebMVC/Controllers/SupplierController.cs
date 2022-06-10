using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierServiceAsync supplierServiceAsync;
        public SupplierController(ISupplierServiceAsync supservice)
        {
            supplierServiceAsync = supservice;
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
            return View(model);
        }
    }
}
