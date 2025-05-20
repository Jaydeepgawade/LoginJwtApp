namespace LoginJwtApp.Models
{
    public class User
    {
        #region Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        #endregion
    }
}
