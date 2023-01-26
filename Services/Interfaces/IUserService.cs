using JwtWeatherApi.Models;
using JwtWeatherApi.Repositories;

namespace JwtWeatherApi.Services.Interfaces
{
    public interface IUserService
    {
        public User Get(UserLogin login);
    }
}
