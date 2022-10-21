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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstMens_Click(object sender, EventArgs e)
        {
            //criar ou instanciar o objeto da classe Mensalista

            Mensalista objMensalista = new Mensalista(); 

            //set

            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2")
                + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                '\n' + objMensalista.VerificaHome()); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                 Convert.ToInt32(txtMatricula.Text),
                 txtNome.Text,
                 Convert.ToDateTime(txtData.Text),
                 Convert.ToDouble(txtSalario.Text));




            //get
            MessageBox.Show("Matrícula     : " + objMensalista.Matricula + "\n" +
                            "Nome          : " + objMensalista.NomeEmpregado + "\n" +
                            "Data Entrada  : " +
                            objMensalista.DataEntradaEmpresa.ToShortDateString() +
                            "\n" +
                            "Salário Bruto : " +
                            objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho());

        }

        private void rbtnNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
