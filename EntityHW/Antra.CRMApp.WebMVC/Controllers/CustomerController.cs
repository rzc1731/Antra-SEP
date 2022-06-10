using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Antra.CRMApp.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServiceAsync customerServiceAsync;
        public CustomerController(ICustomerServiceAsync supservice)
        {
            customerServiceAsync = supservice;
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
            return View(model);
        }
    }
}
