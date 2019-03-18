using System;
using System.Collections.Generic;
using Cinq.Dojo.Solid.DoJeitoSERTU;
using Xunit;
using Xunit.Abstractions;

namespace Cinq.Dojo.Solid.EndTest
{
    public class Funcionario
    {
        private readonly ITestOutputHelper _output;

        public Funcionario(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void FuncionarioTest()
        {
            var lista = new List<DoJeitoSERTU.Funcionario>
            {
                new Gerente()
                {
                    Cargo = CargoEnum.Gerente,
                    Nome = "Boss",
                    Bonus = 1000,
                    Salario = 25000
                },
                new Vendedor
                {
                    Nome = "Sidinelson",
                    Cargo = CargoEnum.Vendendor,
                    Salario = 1300,
                    Comissão = 10
                }
            };
            
            var folha = new FolhaSalarial(_output);
            folha.ImprimirFolhaSalarial(lista);
        }
    }
}
