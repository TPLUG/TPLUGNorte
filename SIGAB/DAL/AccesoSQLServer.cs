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

        /// <summary>
        /// Ejecuta un StoredProcedure que no recibe parámetros.
        /// </summary>
        /// <param name="nombreSP">Nombre del SP.</param>
        /// <returns>Un SqlDataReader.</returns>
        public SqlDataReader EjecutarSP_DR(string nombreSP)
        {
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            AbrirConexion();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;
            dr = command.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// Ejecuta un StoredProcedure que recibe un sólo parametro.
        /// </summary>
        /// <param name="nombreSP">Nombre del SP.</param>
        /// <param name="nombreParametro">Nombre del parámetro del SP.</param>
        /// <param name="codigo">Valor del código.</param>
        /// <returns>Un SqlDataReader.</returns>
        public SqlDataReader EjecutarSP_DR(string nombreSP, string nombreParametro, int codigo)
        {
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            AbrirConexion();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;
            command.Parameters.AddWithValue(nombreParametro, codigo);
            dr = command.ExecuteReader();
            return dr;
        }

        // Terminar
        public DataSet EjecutarQuery_DS()
        {
            DataSet dataSet = new DataSet();
            return dataSet;
        }

        public DataSet EjecutarSP_DS(string nombreSP)
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand();            AbrirConexion();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            CerrarConexion();
            return ds;
        }

        /// <summary>
        /// Ejecuta un StoredProcedure y devuelve un entero que representa
        /// si la operación se realizo con éxito.
        /// </summary>
        /// <param name="nombreSP">Nombre del SP.</param>
        /// <param name="parametros">lista de arrays de la forma [Nombre parametro, valor parametro].</param>
        /// <returns>Un SqlDataReader.</returns>
        public int EjecutarSP_int(string nombreSP, List<object[]> parametros)
        {
            int resultado = 0;

            AbrirConexion();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nombreSP;

            foreach (object[] param in parametros)
            {
                command.Parameters.AddWithValue(param[0].ToString(), param[1]);
            }

            try
            {
                if (command.ExecuteNonQuery() > 0)
                    resultado = 1;
            }
            catch (SqlException e)
            {
                // Se produjo un error a nivel SQL.
                // Puede ocurrir por clave duplicada, clave foránea inexistente, etc.
            }
            finally
            {
                CerrarConexion();
            }

            return resultado;
        }
    }
}
