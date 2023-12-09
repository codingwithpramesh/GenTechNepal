using GenTechNepal.API.Models;

namespace GenTechNepal.API.Data.Interface
{
    public interface IuserService
    {

        IEnumerable<User> GetAll();

        User GetById(int id);

        Task<User> AddAsync(User user, IFormFile file);

        User update(User user);

        void Delete(int id);
    }
}
