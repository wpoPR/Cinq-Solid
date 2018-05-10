using System;
using System.Collections.Generic;

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
            return Salario + Comissão;
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
        public void ImprimirFolhaSalarial(IList<Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Nome} -- {funcionario.CalcularSalario()}");
            }
        }
    }

    public enum CargoEnum
    {
        Vendendor,
        Gerente
    }
}