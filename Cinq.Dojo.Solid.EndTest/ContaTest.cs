using Cinq.Dojo.Solid.DoJeitoSERTU;
using Xunit;
using Xunit.Abstractions;

namespace Cinq.Dojo.Solid.EndTest
{
    public class ContaTest
    {
        private readonly ITestOutputHelper _output;

        public ContaTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void DepositarTest()
        {
            var contaA = new ContaCorrente()
            {
                Documento = "123456789",
                Limite = 1500,
                Saldo = 350,
                Tipo = TipoContaEnum.ContaCorrente
            };

            var contaB = new ContaCorrente()
            {
                Documento = "987654321",
                Limite = 0,
                Saldo = 350,
                Tipo = TipoContaEnum.Poupanca
            };

            var factory = new ContaConrrenteFactory();
            var service = factory.GetService(contaA);

        }
    }
}