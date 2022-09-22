using Microsoft.AspNetCore.Mvc;

namespace LibraryWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        string myString = "hola mundo";
        return myString;
    }
}