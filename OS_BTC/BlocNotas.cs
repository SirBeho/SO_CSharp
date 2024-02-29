using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace OS_BTC
{
    public partial class BlocNotas : Form
    {
        private string rutaArchivoActual = "";
        private Form1 Home;

        public BlocNotas(Form1 Home, string rutaArchivoActual)
        {
            InitializeComponent();
            this.rutaArchivoActual = rutaArchivoActual;
            this.Home = Home;

            if (string.IsNullOrEmpty(rutaArchivoActual))
            {
                toolStripButton1.Enabled = false;
            }
            else
            {
                

                


                this.Text = "Bloc de Notas - " + rutaArchivoActual;
                TextContent.Text = File.ReadAllText(rutaArchivoActual);
                Console.WriteLine("Archivo cargado con éxito desde la ruta existente: " + rutaArchivoActual);
                Console.WriteLine("Contenido del archivo: " + File.ReadAllText(rutaArchivoActual));

                

            }
        }

        private void guardarComoToolStripButton_Click(object sender, EventArgs e)
        {
          

            using (ExploradorGuardar saveFileDialog = new ExploradorGuardar(Home))
            {

                saveFileDialog.StartPosition = FormStartPosition.CenterParent;
                saveFileDialog.Owner = this;

                try
                {

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Console.WriteLine(saveFileDialog.ruta);
                        File.WriteAllText(saveFileDialog.ruta, TextContent.Text);
                        rutaArchivoActual = saveFileDialog.ruta;
                        toolStripButton1.Enabled = true;
                        this.Text = "Bloc de Notas - " + rutaArchivoActual;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
    
            }
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(rutaArchivoActual))
                {
                    File.WriteAllText(rutaArchivoActual, TextContent.Text);
                    Console.WriteLine("Archivo guardado con éxito en la ruta existente: " + rutaArchivoActual);
                }
                else
                {
                    // Si la ruta del archivo actual está vacía, llamar al método GuardarComo
                    guardarComoToolStripButton_Click(sender, e);
                }
                MessageBox.Show("Archivo guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            Home.btn_abrir_nota_Click("");

        }
    }
}
