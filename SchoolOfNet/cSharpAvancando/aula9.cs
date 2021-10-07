using System;

namespace cSharpAvancando
{
    class aula9
    {     
        public struct Cliente
        {
            public int Matricula;
            public string Nome;
            public string Email;
        
            public void DigaOi(){
                System.Console.WriteLine($"oi {this.Nome}");
            }
        }   
        static void Metodo()
        {
            Cliente cliente = new Cliente();
            cliente.Matriculo=123;
            cliente.Nome="OlaMundo";
            cliente.Email="email@email.com"
            cliente.DigaOi();
        }
    }
}
