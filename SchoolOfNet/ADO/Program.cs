using System;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuOpcoes();
            var resp = Console.ReadLine();
            int opc = 0;
            while (resp.ToLower() != "x")
            {
                if (int.TryParse(resp, out _))
                {
                    opc = int.Parse(resp);
                }
                switch (opc)
                {
                    case 1:
                        Console.Title = "Listagem de clientes";
                        Console.WriteLine("======= LISTAGEM DE CLIENTES =======");
                        ListarClientes();
                        break;
                    case 2:
                        Console.Title = "Novo cliente";
                        Console.WriteLine("======= CADASTRO DE NOVO CLIENTE =======");
                        CadastraCliente();
                        break;
                    case 3:
                        Console.Title = "Alteração cliente";
                        Console.WriteLine("======= ALTERAÇÃO DE CLIENTE =======");
                        AtualizaCliente();
                        break;
                    case 4:
                        Console.Title = "Exclusão de cliente";
                        Console.WriteLine("======= EXCLUSÃO DE CLIENTE =======");
                        DeletarCliente();
                        break;
                    case 5:
                        Console.Title = "Visualização de cliente";
                        Console.WriteLine("======= VER DETALHES DE CLIENTE =======");
                        VisualizaCliente();
                        break;
                    default:
                        Console.Title = "Opção Inválida";
                        Console.WriteLine("======= Selecione uma opção valida =======");
                        break;
                }
                Console.Write("Opção:");
                resp = Console.ReadLine();
                opc = 0;
            }
        }

        private static void MenuOpcoes()
        {
            Console.WriteLine("======= CONTROLE DE CLIENTES =======");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("5 - Visualizar");
            Console.Write("Opção:");
        }

        static string CadastraCliente()
        {
            Console.Write("Nome:");
            var nome = Console.ReadLine();
            Console.Write("Email:");
            var email = Console.ReadLine();
            SalvarCliente(nome, email);
            return $"Cliente Cadastrado com sucesso -> nome:{nome} | email:{email}";
        }

        static string AtualizaCliente()
        {
            Console.Write("Id:");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Nome:");
            var nome = Console.ReadLine();
            Console.Write("Email:");
            var email = Console.ReadLine();
            EditarCliente(id, nome, email);
            return $"Cliente editado com sucesso -> nome:{nome} | email:{email}";
        }

        static string DeletarCliente()
        {
            Console.Write("Id:");
            var id = int.Parse(Console.ReadLine());
            DeletarCliente(id);
            return $"Cliente deletado com sucesso -> id:{id}";
        }

        static void VisualizaCliente()
        {
            Console.Write("Id:");
            var id = int.Parse(Console.ReadLine());
            VisualizaCliente(id);
        }

        static void ListarClientes()
        {
            string connString = GetStringConn();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from clientes order by id";
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0}", dr["id"].ToString());
                        Console.WriteLine("Nome:{0}", dr["nome"].ToString());
                        Console.WriteLine("Email:{0}", dr["email"].ToString());
                        Console.WriteLine("------------------------------");
                    }
                };
            };
        }

        static void VisualizaCliente(int id)
        {
            string connString = GetStringConn();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from clientes where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("ID:{0}", dr["id"].ToString());
                        Console.WriteLine("Nome:{0}", dr["nome"].ToString());
                        Console.WriteLine("Email:{0}", dr["email"].ToString());
                        Console.WriteLine("------------------------------");
                    }
                };
            };
        }

        static void SalvarCliente(string nome, string email)
        {
            string connString = GetStringConn();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into clientes(nome,email)values(@nome,@email)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            };
        }

        static void EditarCliente(int id, string nome, string email)
        {
            string connString = GetStringConn();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE clientes SET nome=@nome, email=@email WHERE id=@id";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            };
        }

        static void DeletarCliente(int id)
        {
            string connString = GetStringConn();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE clientes WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            };
        }

        static string GetStringConn() => @"Server=ACER;Database=CSharpAdoNet;User Id=sa;Password=p@ssword";
    }
}
