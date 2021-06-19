using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace cerficacao_csharp_pt2.Aula9___Adicionando_Membros_Dinamicos.Adicionando_propriedades_e_metodos
{
    class UsandoExpandObject : IAulaItem
    {

        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                      "\"Para\": \"Guilherme Silveira\"}";

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = "Ola mundo." + mensagem.Para;

            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
                mensagem.Texto = "Olá, "+ mensagem.Para;
            });

        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }

    //class Mensagem
    //{
    //    public string De { get; set; }
    //    public string Para { get; set; }
    //    public string Texto { get; set; }
    //}
}