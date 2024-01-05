public class ChuckNorrisService
{
  private readonly HttpClient _httpClient;

  public ChuckNorrisService(HttpClient httpClient)
  {
    _httpClient = httpClient;
    _httpClient.BaseAddress = new Uri("https://api.chucknorris.io/");
  }

  public async Task<string> GetRandomJoke()
  {
    var response = await _httpClient.GetStringAsync("jokes/random");
    return response;
  }
}