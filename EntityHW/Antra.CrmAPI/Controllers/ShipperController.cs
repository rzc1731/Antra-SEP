﻿using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperServiceAsync shipperServiceAsync;
        public ShipperController(IShipperServiceAsync shipperServiceAsync)
        {
            this.shipperServiceAsync = shipperServiceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await shipperServiceAsync.GetAllAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await shipperServiceAsync.GetByIdAsync(id);
            if (result == null)
                return NotFound($"Shipper with Id = {id} is not available");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ShipperModel model)
        {
            var result = await shipperServiceAsync.AddShipperAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(ShipperModel model)
        {
            var result = await shipperServiceAsync.UpdateShipperAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await shipperServiceAsync.DeleteShipperAsync(id);
            if (result > 0)
                return Ok("Shipper Deleted successfully");
            return BadRequest();
        }
    }
}
