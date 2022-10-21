using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    class Mensalista : Empregado // especialização -> herança // : é filho/faz parte da classe empregado
    {
        public Double SalarioMensal { get; set; }


        //sobreescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        public Mensalista()
        {
           MessageBox.Show("Passei por aqui");
        }

        public Mensalista(Double x)
        {
            MessageBox.Show("Passei por aqui");
        }

        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
    }  

}
