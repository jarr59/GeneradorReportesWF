using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public partial class FrmAgregarTipo : Form
    {
        public string tipoAgregado;

        private string[] tipoUsuarioExistentes;

        public FrmAgregarTipo(string[] _tipoUsuarioExistentes)
        {
            tipoUsuarioExistentes = _tipoUsuarioExistentes;
            tipoAgregado = string.Empty;
            InitializeComponent();
        }


        private void FrmAgregarTipo_Load(object sender, EventArgs e)
        {

            AdminBD adminBD = new AdminBD();

            adminBD.AbrirConexion();


            string comando = string.Empty;
            comando = "SELECT Tipo FROM PersonaTipo WHERE ";
            for (int i = 0; i < tipoUsuarioExistentes.Length; i++)
            {
                if (i == 0)
                {
                    comando += $"Tipo <> '{tipoUsuarioExistentes[i]}' ";
                }
                else
                {
                    comando += $" AND Tipo <> '{tipoUsuarioExistentes[i]}'";
                }
              
            }

            SqlDataReader dataReader = (SqlDataReader)adminBD.EjecutarComando(comando);

            DataTable dt = new DataTable();

            if (dataReader != null)
            {
                dt.Load(dataReader);

                adminBD.CerrarConexion();
            }

            CmbTipos.DataSource = dt;
            CmbTipos.DisplayMember = "Tipo";
            CmbTipos.SelectedIndex = -1;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string seleccion = CmbTipos.Text;
            if (!string.IsNullOrEmpty(CmbTipos.Text))
            {
                tipoAgregado = CmbTipos.Text;
                this.Close();
            }          
        }
    }
}
