using System;

namespace Cinq.Dojo.Solid.DoJeitoSERTU
{
    public interface IFuncaoScrumMaster
    {
        void BlindarTime();
    }

    public class ScrumMaster : IFuncaoScrumMaster
    {
        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!!!");
        }
    }

    public interface IFuncaoProductOwner
    {
        void PriorizarBacklog();
    }

    public class ProductOwner : IFuncaoProductOwner
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando backlog com base nas minhas necessidades de negócio");
        }
    }

    public interface IFuncaoDev
    {
        void ImplementarFuncionalidades();
    }

    public class Dev : IFuncaoDev
    {
        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codificando e tomando café compulsivamente!!");
        }
    }
}