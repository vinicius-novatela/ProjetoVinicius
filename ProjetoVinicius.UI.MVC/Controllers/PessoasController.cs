using ProjetoVinicius.Domain.Entities;
using ProjetoVinicius.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoVinicius.UI.MVC.Controllers
{
    public class PessoasController : Controller
    {

        //PessoaService _PessoaService = new PessoaService();

        protected PessoaService _PessoaService;
        public PessoasController()
        {
            _PessoaService = new PessoaService();
        }

        

        public ActionResult Index()
        {
            return View(_PessoaService.GetAll());
        }
      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {
            try
            {
                _PessoaService.Add(pessoa);
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
                Pessoa pessoa = _PessoaService.GetPessoa(id);
                return View(pessoa);
            }
            catch
            {               
                return View("Index");
            }
        }
     
        [HttpPost]
        public ActionResult Edit(Pessoa obj)
        {
            try
            {            
                _PessoaService.Update(obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new Pessoa());
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
               Pessoa pessoa =_PessoaService.GetPessoa(id);          
               return View(pessoa);
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

      
        [HttpPost]
        public ActionResult delete(int id)
        {
            try
            {
                 Pessoa pessoa = _PessoaService.GetPessoa(id);
                _PessoaService.Remove(pessoa);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new Pessoa());
            }         
        }


    }
}
