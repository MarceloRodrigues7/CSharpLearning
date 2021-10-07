using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace curso1.Controllers
{
    [Route("Admin")]
    public class AdminController:Controller
    {
        [HttpGet("")]
        public IActionResult Index(){
            return Content("Olá mundo - school of net");
        }

        [HttpGet("son/{nome:string}")]
        public IActionResult schoolOfNet(string nome){
            return Content("Aprendendo ASP.net core na school of net - " + nome);
        }

        [HttpGet("son2")]
        public IActionResult schoolOfNet2(){
            var nome = Request.Query["nome"];
            return Content("Aprendendo ASP.net core na school of net - " + nome);
        }

        [HttpGet("view")]
        public IActionResult visualizar(){
            ViewData["helloworld"]=false;
            return View();
        }

        [HttpGet("form")]
        public IActionResult form(){
            return View();
        }

        [HttpPost("dados")]
        public IActionResult dados(){
            StringValues nome;
            StringValues email;
            Request.Form.TryGetValue("nome",out nome);
            Request.Form.TryGetValue("email",out email);
            return Content($"Formulario enviado - {nome} - {email}");
        }
    }
}