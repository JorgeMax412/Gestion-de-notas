using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_notas.ClasesSQL
{
    class ConexionSQL
    {
        private string cadenaConexion = "Data Source=JORGE-LAPTOP\\SQLEXPRESS; Initial Catalog=pruebaProyectoNotas; Integrated Security=True";
        SqlConnection Conexion;

        public SqlConnection establecerConexion()
        {
            Conexion = new SqlConnection(cadenaConexion);
            return Conexion;
        }
        //Method CREATE, UPDATE, DELETE
        public bool comandosSinRetornoDatos(string strComando)
        {

            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = strComando;
                Comando.Connection = this.establecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Sobrecarga Method CREATE, UPDATE, DELETE
        public bool comandosSinRetornoDatos(SqlCommand SQLcomando)
        {

            try
            {
                SqlCommand Comando = SQLcomando;
                Comando.Connection = this.establecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method SELECT
        public DataSet ejecutarSentencia(SqlCommand sqlComando)
        { 
            DataSet dataSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;
                comando.Connection = establecerConexion();
                adaptador.SelectCommand = comando;
                Conexion.Open();
                adaptador.Fill(dataSet);
                Conexion.Close();
                return dataSet;
            }
            catch
            {
                return dataSet;
            }
        }
    }
}
