using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdmCondominio.model;

namespace TesteProjeto
{
    [TestClass]
    public class AlunoUnitTest
    {
        private Aluno criaAlunoBom()
        {
            return new Aluno()
            {
                Nome = "Maluf",
                NotaB1 = 10,
                NotaB2 = 10
            };
        }

        [TestMethod]
        public void AlunoBomMediaDezTest()
        {
            Aluno aluno = criaAlunoBom();
            Assert.AreEqual(10, aluno.Media);
        }
        [TestMethod]
        public void AlunoBomMediaNaoEhCinco()
        {
            Aluno aluno = criaAlunoBom();
            Assert.AreNotEqual(5, aluno.Media);
        }
        [TestMethod]
        public void AlunoBomIsAprovado()
        {
            Aluno aluno = criaAlunoBom();
            Assert.IsTrue(aluno.IsAprovado);
        }


    }
}
