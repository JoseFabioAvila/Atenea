using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Atenea.Models;
using System.Data;

namespace Atenea.Controllers
{
    public class CPalabras
    {
        Models.Palabras palabras = new Models.Palabras();
        SqlConnection conexion = new SqlConnection();
        CIdiomas cidioma = new CIdiomas();

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
        public bool Agregar(byte id, String nombre, Idiomas idioma)
        {
            bool respuesta = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text; 
                command.CommandText = "INSERT INTO Palabra(ID, Nombre, Idioma) VALUES(@idv, @nomv, @idiomav)";
                command.Parameters.AddWithValue("@idv", id);
                command.Parameters.AddWithValue("@nomv", nombre);
                command.Parameters.AddWithValue("@idiomav", idioma.getID());

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
                command.CommandType = CommandType.Text; 
                command.CommandText = "DELETE FROM Palabra WHERE ID = @idv";
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
        public bool EditarNombre(byte id, String nombre)
        {
            bool respuesta = false;

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE Palabra SET Nombre = @nomv WHERE ID = @idv";
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
        public Palabras Select(int id)
        {
            Palabras result = new Palabras();
            try
            {
                if (conectarServer())
                {
                    // select * from Palabra where ID = 0;
                    string sql = @"select * from Palabra where ID = " + id + "; ";
                    using (var command = new SqlCommand(sql, conexion))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var list = new List<Palabras>();
                            while (reader.Read())
                            {
                                result = new Palabras(reader.GetInt64(0),reader.GetString(1), cidioma.Select(reader.GetByte(2)));
                                //result.setNombre(reader.GetString(1));
                                //result.setIdioma(cidioma.Select(reader.GetByte(2)));
                            }
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
            return result;
        }
    }
}