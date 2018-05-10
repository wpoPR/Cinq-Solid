using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cinq.Dojo.Solid.Test
{
    [TestClass]
    public class ScrumTest
    {
        /*
        * Criar um serviço que gerencie as funçoes de um time de Scrum( Dev | ScrumMaster | ProductOwner)
        * Funcoes : PriorizarBackLog | BlindarTime | ImplementarFuncionalidade
        * REGRA:
        *  - Apenas o ProductOwner pode priorizar o backlog
        *  - Apenas o ScrumMaster pode Blindar o time
        *  - Apenas o Dev pode Implementar a funcionalidade
        *  *- cada funcao apenas vai imprimir na tela uma mensagem que passou ali.
        *  Classe já está criada em Projeto/Core/Dev
        */

        [TestMethod]
        public void Dev_tenta_implementar_test()
        {
            
        }

        [TestMethod]
        public void ProductOwner_tenta_priorizar_test()
        {

        }

        [TestMethod]
        public void ScrumMaster_tenta_blindar_test()
        {

        }
    }
}