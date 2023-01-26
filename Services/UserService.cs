using JwtWeatherApi.Models;
using JwtWeatherApi.Repositories;
using JwtWeatherApi.Services.Interfaces;

namespace JwtWeatherApi.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin login)
        {

            User user = UserRepository.users.FirstOrDefault(x => x.Username.Equals(
                login.username, StringComparison.OrdinalIgnoreCase) && x.Password.Equals(login.Password));

            return user;
        }
    }
}
