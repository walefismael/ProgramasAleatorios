using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("boa");
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (txt1.Text == string.Empty || txt2.Text == string.Empty || (rbSim.Checked == false && rbNao.Checked == false))
            {
                MessageBox.Show("Preencha tds campos");
            }

            else
            {

                if (rbSim.Checked == true)
                {
                    txtResultado.Text = "foi marcado";

                }
                else
                {
                    rbNao.Checked = false;

                    txtResultado.Text = "nao foi marcado";
                }

                rbSim.Checked = false;
                rbNao.Checked = false;
            }
        }
            private void RbNao_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void RbSim_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void Panel1_Paint(object sender, PaintEventArgs e)
            {

            }
        
    }
}
