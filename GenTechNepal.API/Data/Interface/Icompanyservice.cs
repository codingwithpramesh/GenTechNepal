using GenTechNepal.API.Models;

namespace GenTechNepal.API.Data.Interface
{
    public interface Icompanyservice
    {

        IEnumerable<Company> GetAll();

        Company GetById(int id);

        Task<Company> AddAsync(Company company, IFormFile file);

        Company update(Company company);

        void Delete(int id);
    }
}
