using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_pt3
{
    class Program
    {
        static void Main()
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "Jose",
                DataNascimento = new DateTime(1990, 1, 1)
            };
            Aluno aluno2 = new Aluno
            {
                Nome = "Jose",
                DataNascimento = new DateTime(1995, 1, 2)
            };
            Aluno aluno3 = new Aluno
            {
                Nome = "jose",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno4 = new Aluno
            {
                Nome = "André",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno
            {
                Nome = "Ana",
                DataNascimento = new DateTime(1990, 2, 4)
            };

            var alunos = new List<Aluno>
            {
                aluno1,
                aluno2,
                aluno3,
                aluno4,
                aluno5
            };

            Console.WriteLine(aluno1.Equals(aluno2));
            Console.WriteLine(aluno1.Equals(aluno3));

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.ReadKey();
        }
    }
    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase)
                && this.DataNascimento.Equals(outro.DataNascimento);
        }

        public override int GetHashCode()
        {
            int hashCode = -1523756618;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + DataNascimento.GetHashCode();
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            //retorna 0 => objetos são iguais
            //retorna > 0 => objeto atual vem depois
            //retorna < 0 => objeto atual vem antes
            if (obj == null)
            {
                return 1;
            }
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                throw new ArgumentException("Objeto não é um Aluno");
            }
            var resultado = this.DataNascimento.CompareTo(outro.DataNascimento);
            if (resultado==0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }
            return resultado;
        }
    }
}
