using System;

namespace cSharpAvancando
{  
    class aula8
    {    
        public enum TipoCliente{
            PessoaFisica,PessoaJuridica,OrgaoPublico,ONG
        }

        public enum StatusPedido{
            AguardandoPagamento=1,
            Aprovado=2
        }

        static void Metodo()
        {
            TipoCliente.PessoaFisica="OlaMundo";
            //StatusPedido.
        }
        
    }
}
