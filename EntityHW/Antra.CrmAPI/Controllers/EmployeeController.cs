﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Antra.CRMApp.Core.Contract.Service;
using Antra.CRMApp.Core.Model;

namespace Antra.CrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServiceAsync employeeServiceAsync;

        public EmployeeController(IEmployeeServiceAsync empservice)
        {
            employeeServiceAsync = empservice;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await employeeServiceAsync.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await employeeServiceAsync.GetByIdAsync(id);
            if (result == null)
                return NotFound($"Employee with Id = {id} is not available");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeRequestModel model)
        {
            var result = await employeeServiceAsync.AddEmployeeAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeRequestModel model)
        {
            var result = await employeeServiceAsync.UpdateEmployeeAsync(model);
            if (result > 0)
                return Ok(model);
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await employeeServiceAsync.DeleteEmployeeAsync(id);
            if (result > 0)
                return Ok("Employee Deleted successfully");
            return BadRequest();
        }
    }
}
