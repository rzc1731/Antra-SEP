using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierServiceAsync supplierServiceAsync;
        public SupplierController(ISupplierServiceAsync supplierServiceAsync)
        {
            this.supplierServiceAsync = supplierServiceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await supplierServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await supplierServiceAsync.GetByIdAsync(id);
            if (result == null)
                return NotFound($"Supplier with Id = {id} is not available");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SupplierModel model)
        {
            var result = await supplierServiceAsync.AddSupplierAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(SupplierModel model)
        {
            var result = await supplierServiceAsync.UpdateSupplierAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await supplierServiceAsync.DeleteSupplierAsync(id);
            if (result > 0)
                return Ok("Supplier Deleted successfully");
            return BadRequest();
        }
    }
}
