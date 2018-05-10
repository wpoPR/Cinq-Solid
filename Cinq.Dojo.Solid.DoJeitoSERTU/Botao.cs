namespace Cinq.Dojo.Solid.DoJeitoSERTU
{

    public class Botao
    {
        private readonly IDispositivo _dispositivo;

        public Botao(IDispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Acionar()
        {
            if (_dispositivo.Ligado)
            {
                _dispositivo.Ligar();
                return;
            }

            _dispositivo.Desligar();
        }
    }

    public interface IDispositivo
    {
        bool Ligado { get; }
        void Ligar();
        void Desligar();
    }

    public class Lampada : IDispositivo
    {
        public bool Ligado { get; private set; }

        public void Ligar()
        {
            Ligado = true;
        }
        public void Desligar()
        {
            Ligado = false;
        }
    }

    public class Motor : IDispositivo
    {
        public bool Ligado { get; }

        public void Ligar()
        {
            // ligar lampada
        }
        public void Desligar()
        {
            // desligar lampada
        }
    }
}