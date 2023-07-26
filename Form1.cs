using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "joselito" && textBox2.Text == "1234")
            {
                label3.Text = "Datos Correctos";
                this.Hide();
                form2.ShowDialog();
                this.Show();
            } else
            {
                label3.Text = "Datos Incorrectos";
            }
        }
    }
}
