using Microsoft.AspNetCore.Mvc;
using Projeto2b.Repositorio;

namespace Projeto2b.Controllers
{
    public class LoginController : Controller
    {
        //DECLARA UMA VARIÁVEL PRIVADA DOMENTE LEITURA
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //CRIANDO UM CONSTRUTOR = é um inicializador
        public LoginController (UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
 
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            return View();
        }


        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
