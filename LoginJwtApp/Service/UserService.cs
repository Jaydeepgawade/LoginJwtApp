using LoginJwtApp.Models;
using LoginJwtApp.Repository;

namespace LoginJwtApp.Service
{
    public class UserService : IUserService
    {
        #region Field
        private readonly IUserRepository _userRepository;

        #endregion

        #region Ctor
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region Method
        public User ValidateUser(string username, string password)
        {
            return _userRepository.GetUserByCredentials(username, password);
        }

        #endregion
    }
}
