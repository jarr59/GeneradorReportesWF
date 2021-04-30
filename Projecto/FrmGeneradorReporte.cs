using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public partial class FrmGeneradorReporte : Form
    {
        private string _tipo;
         
        public FrmGeneradorReporte()
        {
            _tipo = string.Empty;
            InitializeComponent();
        }

        private void LblClientes_Click(object sender, EventArgs e)
        {
            _tipo = "Cliente";
            ObtenerRegistro();
        }

        private void LblProveedores_Click(object sender, EventArgs e)
        {
            _tipo = "Proveedor";
            ObtenerRegistro();
        }

        private void LblEmpleados_Click(object sender, EventArgs e)
        {
            _tipo = "Empleado";
            ObtenerRegistro();
        }

        private void TsTpPrincipalBtnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerRegistro();
        }

        private void TsTpPrincipalImprimir_Click(object sender, EventArgs e)
        {
            string filtro = string.IsNullOrEmpty(TsTpPrincipalTxtBxBuscar.Text) ? "%" : TsTpPrincipalTxtBxBuscar.Text;

            FrmVistaPreviaReporte vistaPreviaReporte = new FrmVistaPreviaReporte(_tipo, filtro);

            vistaPreviaReporte.Show();
        }
        private void ObtenerRegistro()
        {
            string comandoSql = "SELECT P.ID, PT.[Tipo], P.Saludo, P.Apellido, P.Telefono, P.Direccion1, P.Direccion2,"
                             + " P.Ciudad,P.Estado,P.[CodigoPostal]  FROM Persona P"
                             + $" INNER JOIN PersonaTipo PT ON PT.[PersonaID] = P.[ID] WHERE PT.Tipo = '{_tipo}'";

            if (!string.IsNullOrEmpty(TsTpPrincipalTxtBxBuscar.Text))
            {
                string filtro = TsTpPrincipalTxtBxBuscar.Text;

                comandoSql += $"AND (P.Nombre LIKE '{filtro}%' OR P.Apellido LIKE '{filtro}%'"
                            + $" OR P.Email LIKE '{filtro}%' OR P.Email LIKE '{filtro}%' OR P.Ciudad LIKE '{filtro}%'"
                            + $" OR P.Telefono LIKE '{filtro}%' OR P.CodigoPostal LIKE '{filtro}%'"
                            + $" OR P.Direccion1 LIKE '{filtro}%' OR P.Direccion1 LIKE '{filtro}%')";
            }
            AdminBD adminBD = new AdminBD();
          
            adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)adminBD.EjecutarComando(comandoSql);

            if (lector != null)
            {
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                GrdPrincipal.DataSource = tabla;

                GrdPrincipal.Columns[0].Visible = false;

                lector.Close();
            }

            adminBD.CerrarConexion();
        }
    }
}
