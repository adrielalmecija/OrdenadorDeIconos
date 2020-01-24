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
            Bitmap icono = new Bitmap(ExtractorDeIcono.Extraer().ToBitmap());
            pictureBox1.Image = icono;
            Operaciones.ColorPromedio(icono);

            label1.Text = Operaciones.ColorPromedio(icono).ToString();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
