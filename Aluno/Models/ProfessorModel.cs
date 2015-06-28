using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aluno.Entity;

namespace Aluno.Models
{
    public class ProfessorModel
    {
        private AlunoEntities db = new AlunoEntities();

        public List<Professor> todosProfessores()
        {
            var lista = from a in db.Professor
                        select a;
            return lista.ToList();
        }

        public string adicionarProfessor(Professor a)
        {
            string erro = null;
            try
            {
                db.Professor.AddObject(a);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
        public Professor obterProfessor(int idProfessor)
        {
            var lista = from a in db.Professor
                        where a.idProfessor == idProfessor
                        select a;
            return lista.ToList().FirstOrDefault();
        }
        public List<Professor> listarProfessores(string pesquisa)
        {
            var lista = from a in db.Professor
                        where a.Nome.Contains(pesquisa)
                        select a;
            return lista.ToList();
        }

        public string editarProfessor(Professor a)
        {
            string erro = null;
            try
            {
                if (a.EntityState == System.Data.EntityState.Detached)
                {
                    db.Professor.Attach(a);
                }
                db.ObjectStateManager.ChangeObjectState(a, System.Data.EntityState.Modified);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirProfessor(Professor a)
        {
            string erro = null;
            try
            {
                db.Professor.DeleteObject(a);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
        public string validarProfessor(Professor a)
        {
            if (a.Nome == null || a.Nome == "")
            {
                return "O nome não pode ser vazio!";
            }
            if (a.Materia == null || a.Materia == "")
            {
                return "A matéria não pode ser vazia!";
            }
            if (a.Graduacao == null || a.Graduacao == "")
            {
                return "A graduação não pode ser vazia!";
            }
            if (a.Especializacao == null || a.Especializacao == "")
            {
                return "A especialização não pode ser vazia!";
            }
            return null;
        }
    }
}