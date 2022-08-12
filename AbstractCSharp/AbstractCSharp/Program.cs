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
            carro.SetVelocidadeAtual(true);
            carro.SetVelocidadeAtual(true);

            carro.PararEDesligarGeral();

        }
    }

    abstract class Automovel
    {
        public delegate void ParaGeral();

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
        public abstract void Desligar();
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
        public event ParaGeral PararGeral;

        public Carro()
        {
            PararGeral += () =>
            {
                Console.WriteLine($"Iniciando parada geral - Velocidade atual = {_velocidadeAtual}");
                Console.WriteLine($"Acionando Freios");
                AcionarFreio();
                Console.WriteLine($"Status Freio = {_freio}");

                while (_velocidadeAtual > 0)
                {
                    Console.WriteLine($"Parando - Velocidade atual = {_velocidadeAtual}");
                    if (_velocidadeAtual <= 5)
                    {
                        _velocidadeAtual = 0;
                    }
                    else
                    {
                        _velocidadeAtual -= 5;
                    }
                }

                Console.WriteLine($"Parada geral realizada - Velocidade atual = {_velocidadeAtual}");
            };
        }

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

        public override void Desligar()
        {
            if (_ligado)
            {
                _ligado = false;
                Console.WriteLine("Carro desligado");
            }
            else
            {
                Console.WriteLine("Carro já esta desligado");
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

        public void PararEDesligarGeral()
        {
            if (_ligado)
            {
                PararGeral += () => { Desligar(); };
            }
            PararGeral();
        }


        private void AcionarFreio()
        {
            if (!_freio)
            {
                _freio = true;
                Console.WriteLine("Freio acionado");
            }
            else
            {
                Console.WriteLine("Freio já acionado");
            }
        }

    }
}
