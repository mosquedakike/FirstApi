using FirstWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldController: ControllerBase
{
    private IHelloWorldservice _helloWorldservice;

    public HelloWorldController(IHelloWorldservice helloWorldservice)
    {
        helloWorldservice = _helloWorldservice;
    }

    public IActionResult Get()
    {
        return Ok(_helloWorldservice.GetHelloWorld());
    }
}