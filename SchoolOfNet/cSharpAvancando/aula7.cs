using System;

namespace cSharpAvancando
{
    class aula7
    {
        class Pessoa{
            private string _nome;
            private int _idade;

            public string Nome{
                get=>_nome;
                set=>_nome=value;
            }

            public int Idade{
                get=>_idade;
                set=>_idade=value<=0||value>=120?throw new Exception("Idade inválida"):value;
            }
        }
        
        static void Metodo()
        {
            try
            {
                Pessoa pessoa=new();
                pessoa.Nome="OlaMundo";
                pessoa.Idade=120;     
                System.Console.WriteLine($"Nome:{pessoa.Nome} | Idade:{pessoa.Idade}");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
