using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    class Horista : Empregado
        //nao posso herdar mais de uma classe, nao existe herança multipla
    {

        // prop e 2x tab cria a estrutura da propriedade
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }


        //sobreescrevendo o método
        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        // override indica sobreescrever

        public override int TempoTrabalho()
        {
            // o metodo retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
