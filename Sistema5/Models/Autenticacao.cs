using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema5.Models
{
    public class Autenticacao : IAutenticacao
    {
        public IConfiguration Configuration { get; set; }

        //Le a string de conexão do arquivo de configuração
        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            return connectionString;
        }

        public string RegistrarUsuario(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("RegistrarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);


                con.Open();
                string resultado = cmd.ExecuteScalar().ToString();
                con.Close();

                return resultado;
            }
        }

        public string RegistrarCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("RegistrarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CPF_CNPJ", cliente.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@RG", cliente.RG);
                cmd.Parameters.AddWithValue("@EstadoCivil", cliente.EstadoCivil);
                cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                cmd.Parameters.AddWithValue("@LimiteCredito", cliente.LimiteCredito);
                cmd.Parameters.AddWithValue("@Segmento", cliente.Segmento);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@_Status", cliente._Status);
            


                con.Open();
                string resultado = cmd.ExecuteScalar().ToString();
                con.Close();

                return resultado;
            }
        }

        public string ValidarLogin(Usuario usuario)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("ValidarLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

                con.Open();
                string resultado = cmd.ExecuteScalar().ToString();
                con.Close();

                return resultado;
            }
        }
    }
}
