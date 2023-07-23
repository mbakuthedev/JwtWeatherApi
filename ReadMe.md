# JwtWeatherApi
An Api that uses Jwt token for authorization and authentication.

## Installation

To set up the JwtWeatherApi project locally, follow these steps:

1. Clone the repository to your local machine using Git:

```bash
git clone https://github.com/your-username/JwtWeatherApi.git

## Usage

JwtWeatherApi exposes the following API endpoint:

GET /WeatherForecast: Retrieves a list of weather forecasts.
To access the /WeatherForecast endpoint, you need to authenticate using JWT token-based authentication and have the "Admin" role.

## Configuration

The JwtWeatherApi requires the following configuration settings in the appsettings.json file:

Jwt:Issuer: The issuer of the JWT token.
Jwt:Audience: The audience of the JWT token.
Jwt:Key: The secret key used to sign the JWT token.
Ensure that these settings are properly configured to enable JWT token authentication.




## License

This project is licensed under the MIT License.

