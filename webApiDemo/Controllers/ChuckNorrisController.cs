using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

[Route("/[controller]")]
[ApiController]
public class ChuckNorrisController : ControllerBase
{
  private readonly ChuckNorrisService _chuckNorrisService;

  public ChuckNorrisController(ChuckNorrisService chuckNorrisService)
  {
    _chuckNorrisService = chuckNorrisService;
  }

  [HttpGet("/jokes/random")]
  public async Task<IActionResult> GetRandomJoke()
  {
    var joke = await _chuckNorrisService.GetRandomJoke();
    return Ok(joke);
  }
}