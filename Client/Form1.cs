using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        localhost.Service wsHollerit = new localhost.Service();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtCPF.Text);
            }
            catch
            {
                MessageBox.Show("Aviso", "Só é permitido o uso de caracteres numéricos no CPF");
            }    

        }

        private void txtDependentes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtDependentes.Text);
            }
            catch
            {
                MessageBox.Show("Aviso", "Só é permitido o uso de caracteres numéricos no NÚMERO de dependentes");
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(txtSalario.Text);
            }
            catch
            {
                MessageBox.Show("Aviso", "Só é permitido o uso de caracteres numéricos no salário");
            }
        }
    }
}
