using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovieCore.Controllers
{
    public class HelloWorld : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Esta é minha ação padrão");
        }
        public IActionResult Welcome()
        {
            return View("Seja bem vindo, metodo da ação");
        }
    }
}
