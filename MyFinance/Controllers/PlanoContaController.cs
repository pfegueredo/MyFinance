using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinance.Controllers
{
    public class PlanoContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;

        public PlanoContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            PlanoContaModel objConta = new PlanoContaModel(HttpContextAccessor); //Objeto do tipo PlanoConta
            ViewBag.ListaPlanoConta = objConta.ListaPlanoConta();
            return View();
        }

        [HttpPost]
        public IActionResult CriarPlanoConta(PlanoContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View(formulario);
        }

        [HttpGet]
        public IActionResult CriarPlanoConta(int? id)
        {
            if (id != null)
            {
                PlanoContaModel objPlanoConta = new PlanoContaModel(HttpContextAccessor);
                ViewBag.Registro = objPlanoConta.CarregarRegistro(id);
            }
            return View();
        }



        public IActionResult ExcluirPlanoConta(int id)
        {
            PlanoContaModel objConta = new PlanoContaModel(HttpContextAccessor);
            objConta.Excluir(id);
            return RedirectToAction("Index");
        }

        
    }
}
