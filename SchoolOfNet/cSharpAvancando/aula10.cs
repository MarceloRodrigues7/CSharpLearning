using System;
using System.Collections;
using System.Collections.Generic;

namespace cSharpAvancando
{     
    class aula10
    {     
        class Veiculo{
            private string _marca;
            private string _anoFabricacao;

            public string Marca { get=>_marca; set=>_marca=value;}
            public string AnoFabricacao { get=>_anoFabricacao; set=>_anoFabricacao=value; }
        }

        static void Metodo()
        {
            ArrayList arraylist=new ArrayList();
            arraylist.Add("OlaMundo");
            arraylist.Add(123);
            arraylist.Add(new object());

            List<string>dias = new List<string>();
            dias.Add("DOM");
            dias.Add("SEG");
            dias.Add("TER");
            dias.Add("QUA");
            dias.Add("QUI");
            dias.Add("SEX");
            dias.Add("SAB");

            foreach (var dia in dias)
            {
                System.Console.WriteLine(dia);
            }

            List<Veiculo> veiculos = new List<Veiculo>();
            Veiculo carro=new Veiculo();
            carro.Marca = "Fusca"
            carro.AnoFabricacao=1990;

            Veiculo carro2=new Veiculo();
            carro2.Marca = "Chevetti"
            carro2.AnoFabricacao=1990;

            veiculos.Add(carro);
            veiculos.Add(carro2);

            foreach (var veiculo in veiculos){
                System.Console.WriteLine($"{veiculo.Marca}|{veiculo.AnoFabricacao}");
            }
        }
    }
}
