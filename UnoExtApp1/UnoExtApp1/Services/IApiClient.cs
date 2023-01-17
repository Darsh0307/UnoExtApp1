using UnoExtApp1.DataContracts;

namespace UnoExtApp1.Services;

[Headers("Content-Type: application/json")]
public interface IApiClient
{
	[Get("/api/weatherforecast")]
	Task<ApiResponse<WeatherForecast>> GetWeather(CancellationToken cancellationToken = default);
}
