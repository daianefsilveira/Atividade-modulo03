using AgenciaDeViagem.DATA.Models;
using AgenciaDeViagem.DATA.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaDeViagem.WEB.Controllers
{
    public class PessoasController : Controller
    {
        public PessoasServices oPessoasServices = new PessoasServices();
        public IActionResult Index()
        {
            List<Pessoas> oListPessoas = oPessoasServices.oRepositoryPessoas.SelecionarTodos();
            return View(oListPessoas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pessoas model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            oPessoasServices.oRepositoryPessoas.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Pessoas oPessoas = oPessoasServices.oRepositoryPessoas.SelecionarPk(id);

            return View(oPessoas);
        }

        public IActionResult Edit(int id)
        {
            Pessoas oPessoas = oPessoasServices.oRepositoryPessoas.SelecionarPk(id);
            return View(oPessoas);
        }

        [HttpPost]
        public IActionResult Edit(Pessoas model)
        {
            Pessoas oPessoas = oPessoasServices.oRepositoryPessoas.Alterar(model);
            int id = oPessoas.CódPessoa;
            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oPessoasServices.oRepositoryPessoas.Excluir(id);
            return RedirectToAction("index");
        }




    }
}
