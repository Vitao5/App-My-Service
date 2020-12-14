using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Servicos.Data.Entity_Framework.Comum;
using App_Servicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Servicos.Controllers
{
    public class LoginSistemaController : Controller
    {
        Contexto db = new Contexto();
        public IActionResult Detalhes(int id)
        {
            LoginSistema login = db.LoginSistema.Find(id);
            ViewBag.usuario = login;
            ViewBag.Servicos = db.Servico.Where(a => a.IdTrabalhador == login.IdUsuario).ToList();
            ViewBag.ServicosContratados = db.Servico.Where(a => a.IdCliente == login.IdUsuario).ToList();
            return View(login);
        }
        // public IActionResult Editar(int id)
        // {

        //}
    }
}
