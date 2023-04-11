using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb_num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txb_num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_comp_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(txb_num1.Text);
            int num2 = Convert.ToInt16(txb_num2.Text);

            if (txb_num1.Text != "" && txb_num2.Text != "")
            {
                if (num1 > num2)
                {
                    MessageBox.Show("O primeiro número é maior que o segundo número." + num1);
                }
                else if (num1 < num2)
                {
                    MessageBox.Show("O segundo número é maior que o primeiro número." + num2);
                }
                else
                {
                    MessageBox.Show("Os números são iguais.");
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_num1.Text = "";
            txb_num2.Text = "";
        }
    }
}
