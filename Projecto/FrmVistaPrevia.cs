using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public partial class FrmVistaPrevia : Form
    {
        private string _tipo;

        private string _filtro;

        public FrmVistaPrevia(string tipo, string filtro = "%")
        {
            _filtro = filtro +="%";
            _tipo = tipo;
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FrmVistaPrevia_Load(object sender, EventArgs e)
        {
            ReportParameter reportParameter = new ReportParameter("Tipo",_tipo);
            this.personaTableAdapter.Fill(this.reporteDataSet.Persona, _tipo, _filtro);
            this.RpVwPrincipal.LocalReport.SetParameters(reportParameter);
            this.RpVwPrincipal.RefreshReport();
        }
    }
}
