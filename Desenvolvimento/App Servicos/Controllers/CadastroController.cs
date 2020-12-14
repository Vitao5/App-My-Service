using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_Servicos.Data.Entity_Framework.Comum;
using App_Servicos.Models;

namespace App_Servicos.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(LoginSistema user)
        {
            Contexto db = new Contexto();
            if (user.Senha == null || user.Usuario == null)
            {
                return View(user);
            }
            db.LoginSistema.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SaveEdit(LoginSistema usuario)
        {
            Contexto db = new Contexto();
            db.LoginSistema.Update(usuario);
            db.SaveChanges();
            return RedirectToAction();
        }

        public IActionResult Visualizar()
        {
            List<Cadastro> cadastros = new Contexto().Cadastro.ToList();           
            return View("CadastrosCliente", cadastros);
        }
    }
}
