using Microsoft.AspNetCore.Mvc;

namespace webApiDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChuckNorrisController : ControllerBase
{
  private readonly ChuckNorrisService _chuckNorrisService;

  public ChuckNorrisController(ChuckNorrisService chuckNorrisService)
  {
    _chuckNorrisService = chuckNorrisService;
  }

  [HttpGet("random-joke")]
  public async Task<IActionResult> GetRandomJoke()
  {
    var joke = await _chuckNorrisService.GetRandomJoke();
    return Ok(joke);
  }
}