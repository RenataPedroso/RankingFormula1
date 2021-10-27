using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RankingFormula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Posição 1")
            {
                picE.Load("Piloto1.png");
            }
            else if (comboBox1.Text == "Posição 2")
            {
                picE.Load("piloto2.png");
            }
            else if (comboBox1.Text == "Posição 3")
            {
                picE.Load("piloto3.png");
            }
            else if (comboBox1.Text == "Posição 4")
            {
                picE.Load("piloto4.png");
            }
            else if (comboBox1.Text == "Posição 5")
            {
                picE.Load("piloto5.png");
            }
            else if (comboBox1.Text == "Posição 6")
            {
                picE.Load("piloto6.png");
            }
            else if (comboBox1.Text == "Posição 7")
            {
                picE.Load("piloto7.png");
            }
        }
    }
}
