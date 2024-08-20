using AutoMapper;
using employer_api.DAL.Repositories.Interfaces;
using employer_api.DTOs;
using employer_api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace employer_api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EmployerController(
        IEmployerRepository<Employer> employerRepository,
        IMapper mapper
    ) : ControllerBase
    {
        [HttpGet("get-all")]
        public async Task<ActionResult> GetAll()
        {
            var employerList = await employerRepository.GetAll();
            return Ok(employerList);
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create(CreateEmployerDto employerDto)
        {
            var employer = mapper.Map<Employer>(employerDto);
            await employerRepository.Create(employer);
            return RedirectToAction("GetAll");
        }
    }
}
