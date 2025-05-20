using LoginJwtApp.Models;

namespace LoginJwtApp.Service
{
    public interface IUserService
    {
        #region ServiceField
        User ValidateUser(string username, string password);

        #endregion
    }
}
