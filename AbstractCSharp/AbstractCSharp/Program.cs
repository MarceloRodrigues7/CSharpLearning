using System;

namespace AbstractCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");

            Carro carro = new Carro();

            carro.StatusComponentes();

            carro.Ligar();

            carro.StatusComponentes();

            carro.SetVelocidadeAtual(true);
            carro.SetVelocidadeAtual(true);
            carro.StatusComponentes();

            carro.SetVelocidadeAtual(false);
            carro.StatusComponentes();
        }
    }

    abstract class Automovel
    {
        protected bool _ligado;
        protected int _velocidadeAtual;
        protected int _velocidadeMaxima;
        protected bool _freio;

        public Automovel()
        {
            _ligado = false;
            _velocidadeAtual = 0;
            _freio = true;
        }

        public abstract void Ligar();
        public abstract void SetVelocidadeAtual(bool acelerar);

        public void StatusComponentes()
        {
            Console.WriteLine($"Ligado = {_ligado}");
            Console.WriteLine($"Freiado = {_freio}");
            Console.WriteLine($"Velocidade Atual = {_velocidadeAtual}");
            Console.WriteLine($"Velocidade Maxixa = {_velocidadeMaxima}");
        }

    }
    class Carro : Automovel
    {
        public override void Ligar()
        {
            if (!_ligado && _freio)
            {
                Console.WriteLine("Ligando carro");

                _ligado = true;
                Console.WriteLine("Motor ligado");

                _freio = false;
                Console.WriteLine("Freio removido");
            }
            else
            {
                Console.WriteLine("Carro já esta ligado");
            }
        }

        public override void SetVelocidadeAtual(bool acelerar)
        {
            int velDefault = 10;

            if (_ligado && !_freio)
            {
                _velocidadeAtual = acelerar ? _velocidadeAtual + velDefault : _velocidadeAtual - velDefault;
                Console.WriteLine("Concluido");
            }
            else
            {
                Console.WriteLine("Carro está desligado");
            }
        }
    }
}
