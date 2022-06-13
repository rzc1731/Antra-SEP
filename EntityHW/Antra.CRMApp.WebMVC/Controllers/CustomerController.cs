using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Antra.CRMApp.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServiceAsync customerServiceAsync;
        private readonly IRegionServiceAsync regionServiceAsync;
        public CustomerController(ICustomerServiceAsync supservice, IRegionServiceAsync reg)
        {
            customerServiceAsync = supservice;
            regionServiceAsync = reg;
        }
        public async Task<IActionResult> Index()
        {
            var Collection = await customerServiceAsync.GetAllAsync();
            if (Collection != null)
            {
                return View(Collection);
            }
            List<CustomerModel> model = new List<CustomerModel>();
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
        public async Task<IActionResult> Create(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                await customerServiceAsync.AddCustomerAsync(model);
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
            var custModel = await customerServiceAsync.GetCustomerForEditAsync(id);
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            return View(custModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CustomerModel model)
        {
            ViewBag.IsEdit = false;
            var collection = await regionServiceAsync.GetAllAsync();
            ViewBag.Regions = new SelectList(collection, "Id", "Name");
            if (ModelState.IsValid)
            {
                await customerServiceAsync.UpdateCustomerAsync(model);
                ViewBag.IsEdit = true;

            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await customerServiceAsync.DeleteCustomerAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Info(int id)
        {
            var custModel = await customerServiceAsync.GetByIdAsync(id);
            var region = await regionServiceAsync.GetByIdAsync(custModel.RegionId);
            ViewData["MyRegion"] = region.Name;
            return View(custModel);
        }

        [NonAction]
        public void Demo()
        {
        }
    }
}
