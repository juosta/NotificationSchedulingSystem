using Microsoft.AspNetCore.Mvc;
using Notificationschedulingsystem.Models.DTO;
using Notificationschedulingsystem.Services;
using System;
using System.Threading.Tasks;


namespace Notificationschedulingsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _companyService.GetCompanyNotifications(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCompanyDTO model)
        {
            await _companyService.CreateCompany(model);
            return CreatedAtAction(nameof(Post), new { id = model.Id }, model);
        }
    }
}
