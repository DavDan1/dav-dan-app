
public class ChuckNorrisService
{
  private readonly HttpClient _httpClient;

  public ChuckNorrisService(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }

  public async Task<string> GetRandomJoke()
  {
    var response = await _httpClient.GetStringAsync("https://api.chucknorris.io/jokes/random");
    return response;
  }
}