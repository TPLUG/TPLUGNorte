using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AccesoSQLServer
    {

        private SqlConnection sqlConnection = new SqlConnection();

        private void AbrirConexion()
        {
            sqlConnection.ConnectionString = "Aca va la ruta de la BD";
            sqlConnection.Open();
        }

        private void CerrarConexion()
        {
            sqlConnection.Close();
        }

        public SqlDataReader EjecutarQuery_DR(string Query)
        {
            SqlDataReader dr;

            SqlCommand sqlCommand = new SqlCommand();

            AbrirConexion();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = Query;
            dr = sqlCommand.ExecuteReader();

            return dr;
        }

        // Terminar
        public SqlDataReader EjecutarQuery_DR()
        {
            SqlDataReader dsasd = null;
            return dsasd;
        }

        // Terminar
        public DataSet EjecutarQuery_DS()
        {
            DataSet ds = new DataSet();
            return ds;
        }


        // Terminar
        public DataSet EjecutarSP_DS()
        {
            DataSet ds = new DataSet();
            return ds;
        }
        


    }
}
