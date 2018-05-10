namespace Cinq.Dojo.Solid.Core
{
    public class Botao
    {
        private readonly Lampada _lampada;

        public Botao(Lampada lampada)
        {
            _lampada = lampada;
        }

        public void Acionar(bool ligado)
        {
            if (ligado)
            {
                _lampada.Ligar();
            }
            else
            {
                _lampada.Desligar();
            }
        }
    }

    public class Lampada
    {
        public void Ligar()
        {
            // Ligar
        }

        public void Desligar()
        {
            // Desligar
        }
    }
}