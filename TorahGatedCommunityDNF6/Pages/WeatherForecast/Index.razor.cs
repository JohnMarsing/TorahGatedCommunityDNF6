using System.Net.Http.Json;

namespace TorahGatedCommunityDNF6.Pages.WeatherForecast;

public partial class Index
{
	private IndexVM[]? forecasts;

	protected override async Task OnInitializedAsync()
	{
		forecasts = await Http.GetFromJsonAsync<IndexVM[]>("sample-data/weather.json");
	}
}
