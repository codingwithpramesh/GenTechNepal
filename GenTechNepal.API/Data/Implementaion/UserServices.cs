using GenTechNepal.API.Data.Interface;
using GenTechNepal.API.Models;

namespace GenTechNepal.API.Data.Implementaion
{
    public class UserServices : IuserService
    {

        public UserServices()
        {
            
        }
        public Task<User> AddAsync(User user, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
