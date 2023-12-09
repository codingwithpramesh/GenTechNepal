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
    public class UserController : ControllerBase
    {
        private readonly IuserService _service;
        public UserController(IuserService service)
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
        public IActionResult Create(UserDto user)
        {
            var a = new User
            {
                Username = user.Username,
                FullName = user.FullName,
                EmailAddress = user.EmailAddress,
                ProfilePicture = user.ProfilePicture,
                ContactNumber = user.ContactNumber,
                CompanyId = user.CompanyId,
            };
            _context.users.Add(a);
            _context.SaveChanges();
            return Ok(a);

        }

        [HttpPut("update")]
        public IActionResult update(int id, UserDto user)
        {
            var data = _context.users.Find(id);
            if (data != null)
            {
                data.Username = user.Username;
                data.FullName = user.FullName;
                data.EmailAddress = user.EmailAddress;
                data.ProfilePicture = user.ProfilePicture;
                data.ContactNumber = user.ContactNumber;
                data.CompanyId = user.CompanyId;
                _context.SaveChanges();
                return Ok(data);
            }
            return NotFound();
        }


        [HttpGet("Update")]
        public async Task<IActionResult> Update(int id)
        {
            var data = await _context.users.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }


        [HttpGet("GetDelete")]
        public IActionResult GetDelete(int id)
        {
            var data = _context.users.Find(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var data = _context.users.Find(id);
            if (data != null)
            {
                _context.users.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound();
        }


        [HttpGet("Details")]
        public IActionResult Details(int id)
        {
            var user = _context.users.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
