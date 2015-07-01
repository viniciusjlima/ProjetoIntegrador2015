
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aluno;
using Aluno.Entity;
using Aluno.Models;
using Aluno.Controllers;


namespace TesteUnitarios
{
    [TestClass]
    public class AlunoTest
    {
        public aluno aluno1, aluno2;

        public Professor professor1, professor2;


        [TestInitialize]
        public void InicializarTest()
        {
            aluno1 = new aluno()
            {
                IdAluno = 1,
                Nome = "AlunoTeste1",
                CPF = "11111111111",
                Matricula = "11111111"
            };

            professor1 = new Professor()
            {
                idProfessor = 1,
                Nome = "professorTeste1",
                Graduacao = "Muitas",
                Especializacao = "Muitas Coisas",
                Materia = "PI"
            };

        }

        [TestMethod]
        public void Garantir_Que_2_Alunos_Sao_Iguais_Quando_Tem_Mesmo_Id()
        {
            aluno2 = new aluno()
            {
                IdAluno = 1,
                Nome = "AlunoTeste2",
                CPF = "22222222222",
                Matricula = "22222222"
            };
            Assert.AreEqual(aluno1.IdAluno, aluno2.IdAluno);
        }


        [TestMethod]
        public void Garantir_Que_2_Alunos_Sao_Iguais_Quando_Tem_Mesmo_Login()
        {
            aluno2 = new aluno()
            {
                IdAluno = 1,
                Nome = "AlunoTeste1",
                CPF = "22222222222",
                Matricula = "22222222"
            };
            Assert.AreEqual(aluno1.Nome, aluno2.Nome);
        }

        [TestMethod]
        public void Garantir_Que_2_Alunos_Sao_Iguais_Quando_Tem_Mesmo_CPF()
        {
            aluno2 = new aluno()
            {
                IdAluno = 2,
                Nome = "AlunoTeste2",
                CPF = "11111111111",
                Matricula = "22222222"
            };

            Assert.AreEqual(aluno1.CPF, aluno2.CPF);
        }

        [TestMethod]
        public void Garantir_Que_Nome_comeca_com_a()
        {
            aluno2 = new aluno()
            {
                IdAluno = 2,
                Nome = "AlunoTeste2",
                CPF = "11111111111",
                Matricula = "22222222"
            };

            Assert.AreEqual(aluno1.CPF, aluno2.CPF);
        }

        // ============================ PROFESSOR =======================

        [TestMethod]
        public void Garantir_Que_2_professors_Sao_Iguais_Quando_Tem_Mesmo_Id()
        {
            professor2 = new Professor()
            {
                idProfessor = 1,
                Nome = "professorTeste2",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };
            Assert.AreEqual(professor1.idProfessor, professor2.idProfessor);
        }

        [TestMethod]
        public void Nao_Pode_Inserir_professor_Com_Mesmo_Id_Test()
        {
            //Ambiente
            var professor2 = new Professor()
            {
                idProfessor = 1,
                Nome = "professorTeste2",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };

            //professorModel.adicionarProfessor(professor2);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_Sao_Iguais_Quando_Tem_Mesmo_Login()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste1",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };
            Assert.AreEqual(professor1.Nome, professor2.Nome);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_Sao_Iguais_Quando_Tem_Mesmo_Nome()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste1",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };
            Assert.AreEqual(professor1.Nome, professor2.Nome);
        }

        [TestMethod]
        public void test_obterprofessor()
        {
            int idprofessor = 2;
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };

            Assert.AreEqual(professor2.idProfessor, idprofessor);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_ser_Iguais_Quando_Tem_Mesmo_Graduacao()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste2",
                Graduacao = "Muitas",
                Especializacao = "Muitas Coisas2",
                Materia = "PI2"
            };
            Assert.AreEqual(professor1.Graduacao, professor2.Graduacao);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesmo_Especializacao()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste2",
                Graduacao = "Muita2",
                Especializacao = "Muitas Coisas",
                Materia = "PI2"
            };
            Assert.AreEqual(professor1.Especializacao, professor2.Especializacao);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia00()
        {


            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia9()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia8()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia7()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia6()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia5()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia4()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia3()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia2()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

        [TestMethod]
        public void Garantir_Que_2_professors_podem_Ser_Iguais_Quando_Tem_Mesma_Materia1()
        {
            professor2 = new Professor()
            {
                idProfessor = 2,
                Nome = "professorTeste",
                Graduacao = "Muitas2",
                Especializacao = "Muitas Coisas2",
                Materia = "PI"
            };
            Assert.AreEqual(professor1.Materia, professor2.Materia);
        }

    }
}
