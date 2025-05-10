using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim(); 
            string apellido = textBox2.Text.Trim(); 


            if (!string.IsNullOrEmpty(nombre)) 
            {
                listBox1.Items.Add(nombre); 
                textBox1.Clear(); 
                textBox1.Focus(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!string.IsNullOrEmpty(apellido)) 
            {
                listBox2.Items.Add(apellido);
                textBox2.Clear(); 
                textBox2.Focus(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
