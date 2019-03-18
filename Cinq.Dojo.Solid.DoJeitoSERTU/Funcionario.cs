using System.Collections.Generic;
using Xunit.Abstractions;

namespace Cinq.Dojo.Solid.DoJeitoSERTU
{
    public abstract class Funcionario
    {
        public double Salario { get; set; }

        public CargoEnum Cargo { get; set; }

        public string Nome { get; set; }

        public abstract double CalcularSalario();
    }

    public class Vendedor : Funcionario
    {
        public double Comissão { get; set; }

        public override double CalcularSalario()
        {
            return Salario *  (1 + Comissão);
        }
    }

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }

        public override double CalcularSalario()
        {
            return Salario + Bonus;
        }
    }

    public class FolhaSalarial
    {
        private readonly ITestOutputHelper _output;

        public FolhaSalarial(ITestOutputHelper output)
        {
            _output = output;
        }

        public void ImprimirFolhaSalarial(IList<Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                _output.WriteLine($"{funcionario.Nome} -- {funcionario.CalcularSalario()}");
            }
        }
    }

    public enum CargoEnum
    {
        Vendendor,
        Gerente
    }
}