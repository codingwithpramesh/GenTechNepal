using GenTechNepal.API.Data.Interface;
using GenTechNepal.API.DTO;
using GenTechNepal.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GenTechNepal.API.Data.Implementaion
{
    public class CompanyServices : Icompanyservice
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public CompanyServices(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<Company> AddAsync(Company company, IFormFile file)
        {
            string? fileName = Path.GetFileNameWithoutExtension(file?.FileName);
            string extension = Path.GetExtension(file?.FileName);
            company.CompanyLogo = @"\Images\" + (fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension);
            string path = Path.Combine("/Images/", fileName);
            if (file != null)
            {
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file?.CopyToAsync(fileStream);
                }
            }

            await _context.companies.AllAsync(company);
            await _context.SaveChangesAsync();
            return company;
        }

       

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Company update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
