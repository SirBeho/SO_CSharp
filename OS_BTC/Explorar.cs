using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OS_BTC
{
    public partial class Explorar : Form
    {

       string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "data"));

        public string cancionSeleccionada = "";
        
        public Explorar()
        {
            InitializeComponent();
            this.ControlBox = false;
           this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            CargarEstructuraProyecto();

        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Lógica cuando se hace clic en el botón Aceptar
            DialogResult = DialogResult.OK;
            Close();
        }


        public void CargarEstructuraProyecto()
        {
            treeView1.Nodes.Clear();

            // Crear el nodo raíz
            TreeNode nodoRaiz = new TreeNode("My PC");
            nodoRaiz.Tag = new DirectoryInfo("/");
            treeView1.Nodes.Add(nodoRaiz);


            rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "data"));
            LlenarTreeView(rutaProyecto, nodoRaiz);

           
            nodoRaiz.Expand();


            treeView1.AfterSelect += treeView1_AfterSelect;
           

        }

        private void LlenarTreeView(string carpetaPadre, TreeNode nodoPadre)
        {
            try
            {
                // Obtener subcarpetas y archivos mp3
                string[] subCarpetas = Directory.GetDirectories(carpetaPadre);
                string[] archivos = Directory.GetFiles(carpetaPadre, "*.mp3");
                string[] archivos2 = Directory.GetFiles(carpetaPadre, "*.wav");

                // Agregar subcarpetas al nodo padre
                foreach (string carpeta in subCarpetas)
                {
                    TreeNode nodo = new TreeNode(Path.GetFileName(carpeta));
                    nodo.Tag = new DirectoryInfo(carpeta);
                    nodo.ImageIndex = 0;
                    nodoPadre.Nodes.Add(nodo);

                    LlenarTreeView(carpeta, nodo);
                }

                // Agregar archivos al nodo padre
                foreach (string archivo in archivos)
                {
                    TreeNode nodo = new TreeNode(Path.GetFileName(archivo));
                    nodo.Tag = archivo;
                    nodo.ImageIndex = 1;
                    nodoPadre.Nodes.Add(nodo);
                }
                foreach (string archivo in archivos2)
                {
                    TreeNode nodo = new TreeNode(Path.GetFileName(archivo));
                    nodo.Tag = archivo;
                    nodo.ImageIndex = 1;
                    nodoPadre.Nodes.Add(nodo);
                }

                    

                
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, como imprimir información de depuración o registrar el error
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error de acceso: {ex.Message}", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



            cancionSeleccionada = e.Node.Tag.ToString().Replace("/", "\\");
           
            if (cancionSeleccionada.Contains(".mp3") || cancionSeleccionada.Contains(".wav"))
            {
                DialogResult = DialogResult.OK;
                Close();


            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel ;
            Close();
        }
    }
}
