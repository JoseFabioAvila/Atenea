using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Atenea.Models
{
    public class Conexion
    {
        string Connectthestring = null;
        string sql = null;
        SqlConnection connection;
        SqlCommand command;
        //SqlDataReader dataReader;

        public Conexion() { }

        public int conectar()
        {
            Connectthestring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\fabio\\Documents\\GitHub\\Atenea\\Atenea\\App_Data\\BDConocimiento.mdf;Integrated Security=True";

            sql = "INSERT INTO Idiomas (IdIdioma,Nombre) VALUES ('2','Ingles');";

            connection = new SqlConnection(Connectthestring);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                /*dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {

                }
                dataReader.Close();*/
                command.Dispose();
                //MessageBox.Show("I am connected! B-)");
                connection.Close();
                return 1;
            }
            catch (Exception)
            {
                //MessageBox.Show("Trust me! I tried but I could not open the connection");
                return 2;
            }
        }
    }
}