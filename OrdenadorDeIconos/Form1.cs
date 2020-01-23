using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrdenadorDeIconos
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones.ListarEscritorio();
            pictureBox1.Image = ExtractorDeIcono.Extraer().ToBitmap();
            label1.Text = "presionado";
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
