using GenTechNepal.API.Data.Interface;
using GenTechNepal.API.Models;

namespace GenTechNepal.API.Data.Implementaion
{
    public class UserServices : IuserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public UserServices(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
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
