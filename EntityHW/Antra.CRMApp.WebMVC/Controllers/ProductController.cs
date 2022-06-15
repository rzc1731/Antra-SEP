using Microsoft.AspNetCore.Mvc;
using Antra.CRMApp.WebMVC.Models;
using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.CRMApp.WebMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServiceAsync productServiceAsync;
        private readonly ISupplierServiceAsync supplierServiceAsync;
        private readonly ICategoryServiceAsync categoryServiceAsync;
        public ProductController(IProductServiceAsync prodservice, ISupplierServiceAsync supservice, ICategoryServiceAsync cateservice)
        {
            productServiceAsync = prodservice;
            supplierServiceAsync = supservice;
            categoryServiceAsync = cateservice;
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
            var collectionSupplier = await supplierServiceAsync.GetAllAsync();
            var collectionCategory = await categoryServiceAsync.GetAllAsync();
            ViewBag.Suppliers = new SelectList(collectionSupplier, "Id", "CompanyName");
            ViewBag.Categoriers = new SelectList(collectionCategory, "Id", "Name");
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
            var collectionSupplier = await supplierServiceAsync.GetAllAsync();
            var collectionCategory = await categoryServiceAsync.GetAllAsync();
            ViewBag.Suppliers = new SelectList(collectionSupplier, "Id", "CompanyName");
            ViewBag.Categoriers = new SelectList(collectionCategory, "Id", "Name");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.IsEdit = false;
            var prodModel = await productServiceAsync.GetProductForEditAsync(id);
            var collectionSupplier = await supplierServiceAsync.GetAllAsync();
            var collectionCategory = await categoryServiceAsync.GetAllAsync();
            ViewBag.Suppliers = new SelectList(collectionSupplier, "Id", "CompanyName");
            ViewBag.Categoriers = new SelectList(collectionCategory, "Id", "Name");
            return View(prodModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model)
        {
            ViewBag.IsEdit = false;
            var collectionSupplier = await supplierServiceAsync.GetAllAsync();
            var collectionCategory = await categoryServiceAsync.GetAllAsync();
            ViewBag.Suppliers = new SelectList(collectionSupplier, "Id", "CompanyName");
            ViewBag.Categoriers = new SelectList(collectionCategory, "Id", "Name");
            if (ModelState.IsValid)
            {
                await productServiceAsync.UpdateProductAsync(model);
                ViewBag.IsEdit = true;

            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await productServiceAsync.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Info(int id)
        {
            var prodModel = await productServiceAsync.GetByIdAsync(id);
            var sup = await supplierServiceAsync.GetByIdAsync(prodModel.SupplierId);
            prodModel.Supplier = sup;
            var cate = await categoryServiceAsync.GetByIdAsync(prodModel.CategoryId);
            prodModel.Category = cate;
            return View(prodModel);
        }

        [NonAction]
        public void Demo()
        {
        }
    }
}
