using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_BTC
{
    public partial class ExploradorGuardar : ExploradorArchivos
    {
        public ExploradorGuardar(Form1 home) : base(home)
        {
            InitializeComponent();
        }

        public string ruta;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_nombre.Text))
            {
                Console.WriteLine("Ruta: " + lavel_ruta.Text.Substring(4));
                Console.WriteLine("Ruta: " + lavel_ruta.Text);

               ruta = Path.Combine(rutaProyecto, lavel_ruta.Text.Substring(5), text_nombre.Text+".txt") ;
                Console.WriteLine("Ruta: " + ruta);
                if (!Directory.Exists(ruta))
                {
                   DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un archivo con este nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("El nombre de la carpeta no puede estar vacio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
