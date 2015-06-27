using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aluno.Entity;
using Aluno.Models;
using Aluno.ViewModels;

namespace Aluno.Controllers
{
    public class ProfessorController : Controller
    {
        private ProfessorModel professorModel = new ProfessorModel();

        public ActionResult Index()
        {
            ProfessorViewModel vm = new ProfessorViewModel();
            vm.professores = professorModel.todosProfessores();
            return View();
        }

        public PartialViewResult List(string a)
        {
            var professores = professorModel.listarProfessores(a);
            return PartialView(professores);
        }
        public PartialViewResult Edit(int id)
        {
            Professor a = new Professor();
            if (id != 0)
            {
                a = professorModel.obterProfessor(id);
            }
            return PartialView(a);
        }
        [HttpPost]
        public ActionResult Edit(Professor a)
        {
            string erro = null;
            if (a.idProfessor == 0)
                erro = professorModel.adicionarProfessor(a);
            else
                erro = professorModel.editarProfessor(a);
            if (erro == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Erro = erro;
                return View(a);
            }
        }
        public ActionResult Delete(int id)
        {
            Professor a = professorModel.obterProfessor(id);
            professorModel.excluirProfessor(a);
            return RedirectToAction("Index");
        }

    }
}
