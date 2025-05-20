using LoginJwtApp.Models;

namespace LoginJwtApp.Repository
{
    public interface IUserRepository
    {
        #region Irepositry
        User GetUserByCredentials(string username, string password);

        #endregion
    }
}
