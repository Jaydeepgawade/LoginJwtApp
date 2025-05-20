using LoginJwtApp.Data;
using LoginJwtApp.Models;

namespace LoginJwtApp.Repository
{
    public class UserRepository : IUserRepository
    {
        #region Field
        private readonly ApplicationDbContext _context;

        #endregion

        #region Ctor
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        #endregion

        #region Method
        public User GetUserByCredentials(string username, string password)
        {
            return _context.Users.FirstOrDefault(u =>
                 u.Username == username && u.Password == password);
        }

        #endregion
    }
}
