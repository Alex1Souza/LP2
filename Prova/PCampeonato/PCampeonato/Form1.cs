using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PCampeonato
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnExecutar_Click(object sender, EventArgs e)
        {
            int[,] campeonato = new int[2, 3];

            campeonato[0, 0] = 1;
            campeonato[0, 1] = 3;
            campeonato[0, 2] = 5;
            campeonato[1, 0] = 2;
            campeonato[1, 1] = 3;
            campeonato[1, 2] = 5;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        rtxtResultado.Text = "Time:" + campeonato[i, j] + "Gols feitos " + campeonato[i + 1, j + 1] + "Gols recebidos" + campeonato[i + 1, j + 2];
                    }
                    else if (i == 1 && j == 0)
                    {
                        rtxtResultado.Text = "Time:" + campeonato[i, j] + "Gols feitos " + campeonato[i, j] + campeonato[i, j];
                    }
                }
            }


        }


    }
}

