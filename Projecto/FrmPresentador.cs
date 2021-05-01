using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public partial class FrmPresentador : Form
    {
        private readonly string[] Listatipo = {"Cliente","Proveedor","Empleado"};

        private string _tipo;

        public FrmPresentador()
        {
            _tipo = string.Empty;

            InitializeComponent();
        }

        #region Barra Superior
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Mouse_MouseClick(object args, MouseEventArgs e)
        {
            LblMensajeSeleccioneLista.Visible = false;
            ObtenerRegistro();
        }
        #endregion

        #region FuncionalidadDeArrastrarFormulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Panel Izquierdo

        private void BtnListaClientes_Click(object sender, EventArgs e)
        {
            _tipo = Listatipo[0];
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            _tipo = Listatipo[1];
        }

        private void BtnListaEmpleados_Click(object sender, EventArgs e)
        {
            _tipo = Listatipo[2];

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            BtnCerrar_Click(sender, e);
        }
        #endregion

        #region Barra de busqueda
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBoxBuscar.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerRegistro();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string filtro = string.IsNullOrEmpty(TxtBoxBuscar.Text) ? "%" : TxtBoxBuscar.Text;

            FrmVistaPrevia frmVistaPrevia = new FrmVistaPrevia(_tipo, filtro);

            frmVistaPrevia.Show();
        }
        #endregion

        #region Obtener Listado 
        private void ObtenerRegistro()
        {
            string comandoSql = "SELECT P.ID, PT.[Tipo], P.Saludo, P.Apellido, P.Telefono, P.Direccion1, P.Direccion2,"
                             + " P.Ciudad,P.Estado,P.[CodigoPostal]  FROM Persona P"
                             + $" INNER JOIN PersonaTipo PT ON PT.[PersonaID] = P.[ID] WHERE PT.Tipo = '{_tipo}'";

            if (!string.IsNullOrEmpty(TxtBoxBuscar.Text))
            {
                string filtro = TxtBoxBuscar.Text;

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
        #endregion

        private void FrmPresentador_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tipo))
                LblMensajeSeleccioneLista.Visible = true;
        }
    }
}
