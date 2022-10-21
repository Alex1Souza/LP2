using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            //set

            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFaltas.Text);
            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                "Data Entrada: " +
                objHorista.DataEntradaEmpresa.ToShortDateString() +
                "\n" +
                "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2")
                + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() +
                '\n' + objHorista.VerificaHome());
        }
    }
}
