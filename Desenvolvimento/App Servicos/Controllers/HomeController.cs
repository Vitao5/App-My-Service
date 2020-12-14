using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App_Servicos.Models;
using App_Servicos.Data.Entity_Framework.Comum;

namespace App_Servicos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servico()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(LoginSistema login)
        {
            Contexto db = new Contexto();
            List<LoginSistema> usuarios = db.LoginSistema.ToList();
            LoginSistema usuario = usuarios.Find(a => a.Senha == login.Senha && a.Usuario == login.Usuario);

            if (usuario != null && usuario.Usuario != null && usuario.Senha != null)
            {
                return RedirectToAction("ListarServicos", "Servico", new { idUsuario = usuario.IdUsuario});
            }

            return View(login);
        }

        public IActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroUsuario(LoginSistema login)
        {
            Contexto db = new Contexto();
            if(login.Usuario == null || login.Senha == null)
            {
                return View(login);
            }
            db.LoginSistema.Add(login);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult RemoverUsuario(LoginSistema login)
        {
            if (login.Usuario == null || login.Senha == null)
            {
                RedirectToAction("Index");
            }
            Contexto db = new Contexto();
            db.LoginSistema.Remove(login);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
