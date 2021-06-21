using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt3
{
    class ProjetarInterface
    {
        static void Teste()
        {
            IEletrodomestico eletro1 = new Televisao();
            IEletrodomestico eletro2 = new Abajur();
            IEletrodomestico eletro3 = new Lanterna();
            IEletrodomestico eletro4 = new Radio();

            eletro1 = new Abajur();
            eletro2 = new Televisao();
            eletro3 = new Radio();
            eletro4 = new Lanterna();

            Console.ReadKey();
        }

    }

    interface IEletrodomestico
    {
        event EventHandler Ligou;
        event EventHandler Desligou;
        void Desligar();
        void Ligar();
    }
    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }
    interface IRadioReceptor
    {
        double Frequencia { get; set; }
    }

    class Radio : IEletrodomestico, IRadioReceptor
    {
        public double Frequencia { get; set; }
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Televisao : IEletrodomestico, IRadioReceptor
    {
        public double Frequencia { get; set; }
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }
}
