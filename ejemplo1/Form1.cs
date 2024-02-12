using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // MODIFICADOR PARTIAL: ES UN MODIFICADOR QUE PERMITE LA POSIBILIDAD DE CREAR UNA CLASE DISTRIBUIDA EN DISTINTOS FICHEROS O EN DISTINTOS ARCHIVOS
            InitializeComponent();

            //EVENTO: ES UN METODO ASOCIADO A UN DETERMINADO CONTEXTO( HACER CLICK EN EL BOTON Y QUE ESO EJECUTE TAL METODO ES EL EVENTO, LA ACCION EN CONJUNTO DE TODO)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clase estatica
            //MessageBox.Show("Hola Mundo");
            string texto = txtNombre.Text;
            lblSaludar.Text = "HOLA " + texto;  
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Te doy la bienvenida");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           //MessageBox.Show("Gracias por usar la app!");
        }

    }
}
