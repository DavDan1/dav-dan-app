namespace webApiDemo;

public class ChuckNorrisApiOptions
{
  public ChuckNorrisApiOptions(string baseUrl)
  {
    BaseUrl = baseUrl;
  }

  public string BaseUrl { get; set; }
}