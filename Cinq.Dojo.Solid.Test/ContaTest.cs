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
            // Test 1 => Tipo conta - Poupanca | Saldo R$500 | Debito 42 | Saldo final 558
            // Test 2 => Tipo conta - Corrente | Saldo R$ 300 | limite R$ 1.000 | Debito 420 | Saldo final R$ -120
            // Test 3 => Tipo conta - Corrente | Saldo R$ 800 | limite R$ 2.000 | Debito 800 | Saldo final R$ 0
            var servico = new ContaService();

            // EXEMPLO DE ASSERT => Assert.IsTrue(saldoEsperado == Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
      
        public void Debitar_test_saldoInsuficiente()
        {
            // Test 1 => Tipo conta - Corrente | Saldo R$ 300 | limite R$ 1.000 | Debito 1420
            var servico = new ContaService();
        }

        [TestMethod]
        public void CreditarTest()
        {
            // Test 1 => Tipo conta - Corrente | Saldo R$ -400 | limite R$ 1.000 | Credito 1420
        }

        [TestMethod]
        public void TransferirTest()
        {
            /* TEST 1 - Transferir 500
             * Conta Origem - Poupanca | Saldo 2500
             * Conta Destino - Corrente | Saldo -350 | Limite 400
             */
        }

        [TestMethod]
        public void VerificarSaldoTest()
        {

        }
    }
}