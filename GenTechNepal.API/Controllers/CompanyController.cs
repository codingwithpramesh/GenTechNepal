using GenTechNepal.API.Data;
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
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context)
        {
            _context = context;  
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var data = _context.companies.ToList();
            return Ok(data);
        }

        [HttpPost("Create")]
        public IActionResult Create(CompanyDto company)
        {
            var a = new Company
            {
                Name = company.Name,
                ContactNumber = company.ContactNumber,
                EmailAddress = company.EmailAddress,
               
            };
            _context.companies.Add(a);
            _context.SaveChanges();
            return Ok(a);

        }

        [HttpPut("update")]
        public IActionResult update(int id, CompanyDto company)
        {
            var data = _context.companies.Find(id);
            if (data != null)
            {
                data.Name = company.Name;
                data.EmailAddress = company.EmailAddress;
                data.ContactNumber = company.ContactNumber;
                data.CompanyLogo = company.CompanyLogo;
              
                _context.SaveChanges();
                return Ok(data);
            }
            return NotFound();
        }


        [HttpGet("Update")]
        public async Task<IActionResult> Update(int id)
        {
            var data = await _context.companies.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }


        [HttpGet("GetDelete")]
        public IActionResult GetDelete(int id)
        {
            var data = _context.companies.Find(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var data = _context.companies.Find(id);
            if (data != null)
            {
                _context.companies.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }


        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var user = _context.companies.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
