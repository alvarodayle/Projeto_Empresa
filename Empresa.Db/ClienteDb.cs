using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Runtime.Remoting;


namespace Empresa.Db
{
    public class ClienteDb
    {
        public void Incluir(Cliente cliente)
        {
            string sql = "INSERT INTO Cliente (Id, Nome, Email, Telefone) Values (@Id, @Nome, @Email, @Telefone)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", cliente.id);
            cmd.Parameters.AddWithValue("@Nome", cliente.nome);
            cmd.Parameters.AddWithValue("@Email", cliente.email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.telefone);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sql = "UPDATE Cliente SET Nome = @Nome, Email = @Email, Telefone = @Telefone WHERE Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", cliente.id);
            cmd.Parameters.AddWithValue("@Nome", cliente.nome);
            cmd.Parameters.AddWithValue("@Email", cliente.email);
            cmd.Parameters.AddWithValue("@Telefone", cliente.telefone);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void Excluir(Cliente cliente)
        {
            string sql = "DELETE FROM Cliente Where Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@Id", cliente.id);

            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public List<Cliente> Listar()
        {
            string sql = @"SELECT Id, Nome, Email, Telefone FROM Cliente";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);

            cn.Open();

            List<Cliente> lista = new List<Cliente>();  

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente();
                cliente.id = Convert.ToInt32(reader["Id"]);
                cliente.nome = reader["Nome"].ToString();
                cliente.email = reader["Email"].ToString();
                cliente.telefone = reader["Telefone"].ToString();

                lista.Add(cliente);
            }

            reader.Close();
            cn.Close();

            return lista;
        }

        public Cliente ObterPorId(int id)
        {
            string sql = @"SELECT Id, Nome, Email, Telefone FROM Cliente WHERE Id = @Id";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Id", id);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Cliente cliente = null;
            if (reader.Read())
            {
                cliente = new Cliente();
                cliente.id = Convert.ToInt32(reader["Id"]);
                cliente.nome = reader["Nome"].ToString();
                cliente.email = reader["Email"].ToString();
                cliente.telefone = reader["Telefone"].ToString();
            }
            reader.Close();
            cn.Close();
            return cliente;
        }
    }
}
