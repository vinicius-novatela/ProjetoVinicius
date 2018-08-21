using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoVinicius.UI.MVC.Controllers
{
    public class UsuarioController : Controller
    {

        //PessoaService _PessoaService = new PessoaService();

        protected UsuarioService _UsuarioService;
        public UsuarioController()
        {
            _UsuarioService = new UsuarioService();
        }      

        public ActionResult Index()
        {
            return View(_UsuarioService.GetAll());
        }
      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                _UsuarioService.Add(usuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                Usuario usuario = _UsuarioService.GetUsuarioId(id);
                return View(usuario);
            }
            catch
            {               
                return View("Index");
            }
        }
     
        [HttpPost]
        public ActionResult Edit(Usuario obj)
        {
            try
            {
                _UsuarioService.Update(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new Usuario());
            }
        }
       
        [HttpPost]
        public JsonResult DeletePessoa(int id)
        {
            var msg = "";
            try
            {
               var usuario = _UsuarioService.GetUsuarioId(id);
                _UsuarioService.Remove(usuario);
                msg = "1";
            }
            catch
            {
                msg = "2";
            }
            return Json(msg);
        }

    }
}
