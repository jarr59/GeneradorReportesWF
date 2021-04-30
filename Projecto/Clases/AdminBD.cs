using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public class AdminBD
    {
        private string _instanciaSQL;
        private string _nombreBD;
        private SqlConnection _sqlConnection = null;

        public AdminBD(string instanciaSQL = "", string nombreBD = "")
        {
            if (String.IsNullOrEmpty(instanciaSQL))
                _instanciaSQL = Properties.Settings.Default.InstaciaSQLServer;
            else
                _instanciaSQL = instanciaSQL;

            if (String.IsNullOrEmpty(nombreBD))
                _nombreBD = Properties.Settings.Default.BaseDatos;
            else
                _nombreBD = nombreBD;
        }

        private string ObtenerStringDeConexion()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append($"Server={_instanciaSQL};");

            if (!String.IsNullOrEmpty(_nombreBD))
                strBuilder.Append($"Database={_nombreBD};");

            strBuilder.Append("Trusted_Connection=True;");

            return strBuilder.ToString();
        }

        public void AbrirConexion()
        {
            string stringDeConexion = ObtenerStringDeConexion();

            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = stringDeConexion;
            _sqlConnection.Open();
        }

        public object EjecutarComando(string comandoSQL)
        {
            object resultado = null;
            if (!String.IsNullOrEmpty(comandoSQL))
            {
                try
                {
                    SqlCommand comando = new SqlCommand(comandoSQL, _sqlConnection);

                    if (comandoSQL.ToUpper().StartsWith("SELECT"))
                        resultado = comando.ExecuteReader();
                    else
                        resultado = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CerrarConexion();
                }
            }
            return resultado;
        }

        public void CerrarConexion()
        {
            if (_sqlConnection != null && _sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }
    }
}
