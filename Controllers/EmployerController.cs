using AutoMapper;
using employer_api.DAL.Repositories.Interfaces;
using employer_api.DTOs;
using employer_api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace employer_api.Controllers
{
    [Route("api/employers")]
    [ApiController]
    public class EmployerController(
        IEmployerRepository<Employer> employerRepository,
        IMapper mapper
    ) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetEmployers()
        {
            var employerList = mapper.Map<List<EmployerOutputDto>>(await employerRepository.GetAll());
            return Ok(employerList);
        }

        [HttpGet("employer/{id}")]
        public async Task<ActionResult> GetEmployer(int id)
        {
            var employer = mapper.Map<EmployerOutputDto>(await employerRepository.Get(id));
            return Ok(employer);
        }
 
        [HttpPost]
        public async Task<ActionResult> AddEmployer(EmployerInputDto employerInputDto)
        {
            var employer = mapper.Map<Employer>(employerInputDto);
            await employerRepository.Add(employer);
            return RedirectToAction("GetEmployers");
        }

        [HttpDelete("employer/{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            await employerRepository.Remove(id);
            return RedirectToAction("GetEmployers");
        }

        [HttpPut]
        public async Task<ActionResult> Update(EmployerInputDto employerInputDto)
        {
            var employer = mapper.Map<Employer>(employerInputDto);
            await employerRepository.Update(employer);
            return RedirectToAction("GetEmployers");
        }
    }
}
