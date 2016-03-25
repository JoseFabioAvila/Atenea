using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Atenea.Models;
using System.Data;

namespace Atenea.Controllers
{
    public class CCategorias
    {
        Models.Categorias categorias = new Models.Categorias();
        SqlConnection conexion = new SqlConnection();

        // Muestreo de errores
        private String mostrarError;
        public string MostrarError
        {
            get { return mostrarError; }
            set { mostrarError = value; }
        }

        // Conexion con la Base de datos
        private bool conectarServer()
        {
            bool respuesta = false;
            String cadenaConexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=BD_ATENA;Integrated Security=True";

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                respuesta = true;

            }
            catch (Exception exp)
            {
                respuesta = false;
                mostrarError = "No se ha podido conectar al servidor. Mensaje de la exepcion: " + exp.Message.ToString();
            }

            return respuesta;
        }

        // Agregar Idioma
        public bool Agregar(byte id, String nombre)
        {
            bool respuesta = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text; 
                command.CommandText = "INSERT INTO Categoria(ID, Nombre) VALUES(@idv, @nomv)";
                command.Parameters.AddWithValue("@idv", id);
                command.Parameters.AddWithValue("@nomv", nombre);

                try
                {
                    conectarServer();
                    int recordsAffected = command.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    MostrarError = "Mensaje de la exepcion: " + ex.Message.ToString();
                    respuesta = false;
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        // Borrar Idioma
        public bool Borrar(byte id)
        {
            bool respuesta = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text; //"INSERT INTO Idiomas (ID, Nombre) VALUES("+id+" , "+nombre+");"
                command.CommandText = "DELETE FROM Categoria WHERE ID = @idv";
                command.Parameters.AddWithValue("@idv", id);

                try
                {
                    conectarServer();
                    int recordsAffected = command.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    MostrarError = "Mensaje de la exepcion: " + ex.Message.ToString();
                    respuesta = false;
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        // Modificar Idioma
        public bool Editar(byte id, String nombre)
        {
            bool respuesta = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Categoria SET Nombre = @nomv WHERE ID = @idv";
                command.Parameters.AddWithValue("@idv", id);
                command.Parameters.AddWithValue("@nomv", nombre);

                try
                {
                    conectarServer();
                    int recordsAffected = command.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    MostrarError = "Mensaje de la exepcion: " + ex.Message.ToString();
                    respuesta = false;
                }
                finally
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        // Seleccionar idioma
        public Categorias[] Select(int id)
        {
            Categorias[] lstIdiomas = null;
            try
            {
                if (conectarServer())
                {
                    string sql = @"SELECT* FROM Categoria WHERE ID = " + id + "; ";
                    using (var command = new SqlCommand(sql, conexion))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var list = new List<Categorias>();
                            while (reader.Read())
                            {
                                Categorias i = new Categorias();
                                i.setID(reader.GetByte(0));
                                i.setNom(reader.GetString(1));
                                list.Add(i);
                            }
                            lstIdiomas = list.ToArray();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError = "Mensaje de la excepcio: " + ex.Message.ToString();
            }
            finally
            {
                conexion.Close();
            }
            return lstIdiomas;
        }
    }
}