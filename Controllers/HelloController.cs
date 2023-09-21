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

        [HttpGet("/bsmgenerationbrasil")]
        public string bsmgenerationbrasil()
        {
            return "Persistência \n Mentalidade de Crescimento \n Responsabilidade Pessoal \n Orientação ao Futuro \n Orientação ao Detalhe \n Trabalho em Equipe \n Comunicação \n Proatividade";
        }

        [HttpGet("/objetivos")]
        public string objetivos()
        {
            return "\n Trabalho em Equipe \n Comunicação \n Proatividade";
        }

    }
}


