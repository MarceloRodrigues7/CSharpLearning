using System;

namespace aula6
{
    class Program
    {
        class Carro{
            private string _marca;
            private int _anoFabricacao;
            public string Marca{
                get=>_marca;
                set=>_marca=value.Equals("Fusca")?"Outro":value;
            }
            public int AnoFabricacao{
                get=>_anoFabricacao;
                set=>_anoFabricacao=value;
            }
            public void Buzinar(){
                System.Console.WriteLine("Buzinandoooo");
            }
            public void Virar(string direcao){
                switch (direcao)
                {
                    case "D": 
                        System.Console.WriteLine("Virando a direita");
                        break;
                    case "E":
                        System.Console.WriteLine("Virando a esquerda");
                        break;
                    default:
                        System.Console.WriteLine("Seguindo em linha reta");
                        break;
                }
            }
        }
        static void Metodo()
        {
            Carro carro = new();
            carro.Marca="Fusca";
            carro.AnoFabricacao=1978;
            System.Console.WriteLine($"Tenho um um carro {carro.Marca} do ano {carro.AnoFabricacao}");
            carro.Buzinar();
            carro.Virar("D");
            carro.Virar("");
            carro.Virar("D");
            carro.Virar("E");
            carro.Virar("");
            carro.Buzinar();
        }
    }
}
