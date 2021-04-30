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
    public partial class FrmVistaPreviaReporte : Form
    {
        private string _tipo;

        private string _valor;

        public FrmVistaPreviaReporte(string tipo = "Cliente", string valor = "%")
        {
            _tipo = tipo;

            _valor = valor += "%";

            InitializeComponent();
        }

        private void FrmVistaPreviaReporte_Load(object sender, EventArgs e)
        {
            this.personaTableAdapter.Fill(this.reporteDataSet.Persona, _tipo, _valor);
            this.RpVwVistaPrevia.RefreshReport();
        }
    }
}
