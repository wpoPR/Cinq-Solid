using System;
using Cinq.Dojo.Solid.Test.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cinq.Dojo.Solid.Test
{
    [TestClass]
    public class ContaTest
    {
        /*
         * Criar um serviço que gerencie Conta Corrente e Poupança
         * Transações : Creditar | Debitar | Verificar Saldo | Transferir 
         * OBS : Conta Corrente alem do Saldo existe um limite adcional
         * Classe já criada em Projeto/Core/ContaService
         */
        [TestMethod]
        public void Debitar_test_sucesso()
        {
            var servico = new ContaService();
            // EXEMPLO DE ASSERT => Assert.IsTrue(saldoEsperado == Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Debitar_test_saldoInsuficiente()
        {
            // var servico = new ContaService();
            // EXEMPLO DE ASSERT => Assert.IsTrue(saldoEsperado == Conta.Saldo);
        }

        [TestMethod]
        public void CreditarTest()
        {

        }

        [TestMethod]
        public void TransferirTest()
        {

        }

        [TestMethod]
        public void VerificarSaldoTest()
        {

        }
    }
}