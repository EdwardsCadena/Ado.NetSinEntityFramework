using PruebaTecnica.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PruebaTecnica.Data
{
    class Conexion
    {
        private string connectionDB = " Data Source=.;Initial Catalog=PruebaTecnica;Integrated Security=True";

        public bool ok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionDB);
                connection.Open();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<Cliente> Get()
        {
            List<Cliente> cliente = new List<Cliente>();
            string query = "select IdCliente, Nombres, Apellidos, Direccion from Cliente";

            using (SqlConnection connection = new SqlConnection(connectionDB))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente oCliente = new Cliente();
                        oCliente.IdCliente = reader.GetInt32(0);
                        oCliente.Nombres = reader.GetString(1);
                        oCliente.Apellidos = reader.GetString(2);
                        oCliente.Direccion = reader.GetString(3);
                        cliente.Add(oCliente);
                    }
                    reader.Close();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Hay un error ne la bd"+ ex.Message);
                }
            }
            return cliente;
        }

        public void Add(string Nombre, string Apellidos, string Direccion)
        {
            
            string query = "insert into Cliente (Nombres,Apellidos,Direccion) values (@Nombre, @Apellidos,@Direccion)";

            using (SqlConnection connection = new SqlConnection(connectionDB))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellidos", Apellidos);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Hay un error ne la bd" + ex.Message);
                }
            }
        }

        public Cliente Get(int IdCliente)
        {
            
            string query = "select IdCliente, Nombres, Apellidos, Direccion from Cliente where IdCliente=@IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionDB))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", IdCliente);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    Cliente oCliente = new Cliente();
                    oCliente.IdCliente = reader.GetInt32(0);
                    oCliente.Nombres = reader.GetString(1);
                    oCliente.Apellidos = reader.GetString(2);
                    oCliente.Direccion = reader.GetString(3);
                    reader.Close();
                    connection.Close();
                    return oCliente;

                }
                catch (Exception ex)
                {

                    throw new Exception("Hay un error ne la bd" + ex.Message);
                }
            }
        }

        public void Update(string Nombre, string Apellidos, string Direccion, int IdCliente)
        {

            string query = "update Cliente set Nombres = @Nombre, Apellidos = @Apellidos, Direccion = @Direccion where IdCliente=@IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionDB))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellidos", Apellidos);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@IdCliente", IdCliente);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Hay un error ne la bd" + ex.Message);
                }
            }
        }

        public void Delete(int IdCliente)
        {

            string query = "delete from Cliente where IdCliente=@IdCliente";

            using (SqlConnection connection = new SqlConnection(connectionDB))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", IdCliente);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception("Hay un error ne la bd" + ex.Message);
                }
            }
        }
    }
}
