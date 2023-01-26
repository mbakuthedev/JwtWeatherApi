using JwtWeatherApi.Models;

namespace JwtWeatherApi.Repositories
{
    public class UserRepository
    {
        public static List<User> users = new()
        {
            new() {Username = "Favour12", Email = "favour@gmail.com", Password = "adeogo12", Role = "Admin" },
             new() {Username = "Lydia", Email = "lydy@gmail.com", Password = "adeogo12", Role = "User" }
        };
    }
}
