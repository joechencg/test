using Microsoft.AspNetCore.Mvc;

namespace ViteApi.Controllers
{
  public class TestController : Controller
  {
    public IActionResult index()
    {
      return Ok("Test result");
    }
  }

}