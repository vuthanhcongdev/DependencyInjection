using Microsoft.AspNetCore.Mvc;
using TestDI.Abstractions;

namespace TestDI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ITest1 _test1;
    private readonly ITest2 _test2;
    private readonly ITest3 _test3;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
        ITest1 test1,    
        ITest2 test2,
        ITest3 test3,
        ILogger<WeatherForecastController> logger)
    {
        _test1 = test1;
        _test2 = test2;
        _test3 = test3;
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public object Get()
    {
        var a = _test1.NewInstanceId1();
        var b = _test1.NewInstanceId1();
        
        var c = _test2.NewInstanceId2();
        var d = _test2.NewInstanceId2();

        var e = _test3.NewInstanctId3();
        var f = _test3.NewInstanctId3();
        
        return new { a, b, c, d, e, f };
    }
}