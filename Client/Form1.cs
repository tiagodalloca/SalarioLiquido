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
            if (txtCPF.Text.Length < 11 || txtDependentes.Text == "" || txtSalario.Text == "")
                MessageBox.Show("Preencha todos os campos", "Aviso");


            else if (wsHollerit.isCPFValido(txtCPF.Text))
            {
                lsbResult.Items.Clear();

                var salario = Convert.ToDouble(txtSalario.Text);
                var salariob = salario;

                lsbResult.Items.Add("Salário Bruto: R$" + txtSalario.Text);

                var inss = wsHollerit.calcularINSS(salario);
                salario -= inss;

                lsbResult.Items.Add("INSS: R$" + inss);

                var ir = wsHollerit.calcularIR(salario, Convert.ToInt16(txtDependentes.Text));

                if (ir < 0)
                    ir = 0;

                salario -= ir;

                lsbResult.Items.Add("IR: R$" + ir);
                lsbResult.Items.Add("FGTS: R$" + wsHollerit.calcularFGTS(salariob));
                lsbResult.Items.Add("Salário Líquido: R$" + salario);
            }
            else
                MessageBox.Show("O CPF não está correto :(");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt64(txtCPF.Text);
            }
            catch
            {
                if (txtCPF.Text != "")
                MessageBox.Show("Só é permitido o uso de caracteres numéricos no CPF", "Aviso");
                txtCPF.Text = "";
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
                if (txtDependentes.Text != "")
                {
                    MessageBox.Show("Só é permitido o uso de caracteres numéricos no NÚMERO de dependentes", "Aviso");
                    txtDependentes.Text = "";
                }
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToUInt16(txtSalario.Text);
            }
            catch
            {
                MessageBox.Show("Só é permitido o uso de caracteres numéricos no salário", "Aviso");
                txtSalario.Text = "";
            }
        }

        private void btnFecharRelatorio_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
