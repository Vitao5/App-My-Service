using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Servicos.Data.Entity_Framework.Comum;
using App_Servicos.Models;
using Microsoft.AspNetCore.Mvc;

namespace App_Servicos.Controllers
{
    public class ServicoController : Controller
    {

        Contexto db = new Contexto();

        [HttpGet]
        public IActionResult ListarServicos(int idUsuario)
        {
            List<Servico> servico = db.Servico.Where(a => a.IdTrabalhador != idUsuario).ToList();
            ViewBag.Usuario = db.LoginSistema.Find(idUsuario);
            return View(servico);
        }
        public IActionResult CriarServico(int idUsuario)
        {
            Contexto db = new Contexto();
            ViewBag.Usuario = db.LoginSistema.Find(idUsuario);
            return View();
        }

        [HttpPost]
        public IActionResult CriarServico(Servico servico, int idUsuario)
        {
            Contexto db = new Contexto();
            ViewBag.Usuario = db.LoginSistema.Find(idUsuario);
            servico.IdTrabalhador = ViewBag.Usuario.IdUsuario;
            if (servico.Endereco == null || servico.Descricao == null || servico.NomeServico == null)
            {
                return View(servico);
            }
            db.Servico.Add(servico);
            db.SaveChanges();
            return RedirectToAction("Detalhes", "LoginSistema", new { id = idUsuario});
        }

        public IActionResult ExcluirServico(int id, int idUsuario)
        {
            Servico servico = db.Servico.Find(id);
            db.Servico.Remove(servico);
            db.SaveChanges();
            return RedirectToAction("Detalhes","LoginSistema", new { id = idUsuario});
        }

        public IActionResult EditarServico(int id, int idUsuario)
        {
            ViewBag.Usuario = db.LoginSistema.Find(idUsuario);
            return View(db.Servico.Find(id));
        }

        [HttpPost]
        public IActionResult EditarServico(Servico servico, int idUsuario) 
        {
            ViewBag.Usuario = db.LoginSistema.Find(idUsuario);
            if (servico.Descricao == null || servico.Endereco == null || servico.NomeServico == null || servico.Valor == 0)
            {
                return View(servico);
            }
            db.Servico.Update(servico);
            db.SaveChanges();
            return RedirectToAction("Detalhes","LoginSistema",new { id = idUsuario });
        }

        public IActionResult ContratarServico(int id, int IdUsuario) 
        {
            Servico servico = db.Servico.Find(id);
            servico.IdCliente = IdUsuario;
            db.Servico.Update(servico);
            db.SaveChanges();
            return RedirectToAction("ListarServicos", new { idUsuario = IdUsuario });
        }
        public IActionResult CancelarContrato(int id, int IdUsuario)
        {
            Servico servico = db.Servico.Find(id);
            servico.IdCliente = 0;
            db.Servico.Update(servico);
            db.SaveChanges();
            return RedirectToAction("Detalhes","LoginSistema", new { id = IdUsuario });
        }
    }
}
