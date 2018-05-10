using System;

namespace Cinq.Dojo.Solid.Core
{
    public interface IMembroDeTimeScrum
    {
        void PriorizarBacklog();
        void BlindarTime();
        void ImplementarFuncionalidades();
    }

    public class Dev : IMembroDeTimeScrum
    {
        public void PriorizarBacklog() { }
        public void BlindarTime() { }

        public void ImplementarFuncionalidades()
        {
            Console.WriteLine("Codificando e tomando café compulsivamente!!");
        }
    }

    public class ScrumMaster : IMembroDeTimeScrum
    {
        public void PriorizarBacklog() { }

        public void BlindarTime()
        {
            Console.WriteLine("Devs working! You shall not pass!!!!");
        }

        public void ImplementarFuncionalidades() { }
    }

    public class ProductOwner : IMembroDeTimeScrum
    {
        public void PriorizarBacklog()
        {
            Console.WriteLine("Priorizando backlog com base nas minhas necessidades de negócio");
        }

        public void BlindarTime() { }
        public void ImplementarFuncionalidades() { }
    }
}