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
            string nombre = textBox1.Text.Trim(); // Obtener texto sin espacios al inicio/final

            if (!string.IsNullOrEmpty(nombre)) // Validar que no esté vacío
            {
                listBox1.Items.Add(nombre); // Agregar a la ListBox
                textBox1.Clear(); // Limpiar el TextBox
                textBox1.Focus(); // Regresar el foco al TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
