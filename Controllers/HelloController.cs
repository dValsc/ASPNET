using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{

    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Valéria";
        }

    }
}


