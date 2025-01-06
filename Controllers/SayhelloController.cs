using Microsoft.AspNetCore.Mvc;

namespace KumarTMC_1__SayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayhelloController : ControllerBase
    {
    [HttpGet]
    [Route("SayHello/{name}")]
    public string sayHello(string name){

    return $"hello {name}";
    }
    }
}