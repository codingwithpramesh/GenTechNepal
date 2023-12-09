using GenTechNepal.API.Data;
using GenTechNepal.API.Data.Interface;
using GenTechNepal.API.DTO;
using GenTechNepal.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenTechNepal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly Icompanyservice _service;
        public CompanyController(Icompanyservice service)
        {
            _service = service;  
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CompanyDto company, IFormFile file)
        {
          // await _service.AddAsync(company);
            return Ok();

        }

        [HttpPut("update")]
        public IActionResult update(int id, CompanyDto company)
        {
           /* var data = _context.companies.Find(id);
            if (data != null)
            {
                data.Name = company.Name;
                data.EmailAddress = company.EmailAddress;
                data.ContactNumber = company.ContactNumber;
                data.CompanyLogo = company.CompanyLogo;
              
                _context.SaveChanges();
                return Ok(data);
            }
            return NotFound();*/
           return Ok();
        }


        [HttpGet("Update")]
        public async Task<IActionResult> Update(int id)
        {
            /* var data = await _context.companies.FindAsync(id);
             if (data == null)
             {
                 return NotFound();
             }
             return Ok(data);*/

            return Ok();
        }


        [HttpGet("GetDelete")]
        public IActionResult GetDelete(int id)
        {

            return Ok();
            /*var data = _context.companies.Find(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();*/
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            return Ok();
           /* var data = _context.companies.Find(id);
            if (data != null)
            {
                _context.companies.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();*/
        }


        [HttpGet("Details")]
        public IActionResult Details(int id)
        {

            return Ok();
            /*var user = _context.companies.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);*/
        }
    }
}
