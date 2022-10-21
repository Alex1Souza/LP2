using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula // propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //método são ações/comportamentos

        public String  VerificaHome()//método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office.";
            else
                return "Empregado NÃO trabalha em home office.";
        }

        //virtual --> pode ser subescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo 
            //DateTime.Today - pega horario do momento/hoje
            //TimeSpan - guarda um intervalo de tempo 
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            //DateTime.hoje.subtraia(dataentradaempresa)
            return (span.Days);
            //retorna somente em dias, como tempo de trabalho está em int retorna int.
        }

        //deve ser implementado nas classes filhas (subclasses)

        public abstract double SalarioBruto(); //não preciso implementar por conter abstract, algo que nao existe. 
        //toda classe que tem metodo abstract se torna abstrata, nao pode existir objetos. 
    }


}
