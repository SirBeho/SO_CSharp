using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OS_BTC
{
    public partial class ExploradorArchivos : Form
    {

        //2 subdirectorios antes de la carpeta del proyecto
        public string rutaProyecto ;
        public string selectedFolderPath;
        private Stack<string> historialDeRutas = new Stack<string>();

        private Form1 Home;

        public ExploradorArchivos(Form1 home)
        {
            InitializeComponent();
            CargarEstructuraProyecto();
            this.Home = home;

        
        }

        public ExploradorArchivos()
        {
            InitializeComponent();
            CargarEstructuraProyecto();
           
        }

        public void CargarEstructuraProyecto()
        { 
            treeView1.Nodes.Clear();

            TreeNode proyectoNode2 = new TreeNode("Descargas");
            proyectoNode2.Tag = new DirectoryInfo("descarga");
            treeView1.Nodes.Add(proyectoNode2);

            TreeNode proyectoNode3 = new TreeNode("Documentos");
            proyectoNode3.Tag = new DirectoryInfo("documento");
            treeView1.Nodes.Add(proyectoNode3);

            // Crear el nodo raíz
            TreeNode nodoRaiz = new TreeNode("My PC");
            nodoRaiz.Tag = new DirectoryInfo("/");
            treeView1.Nodes.Add(nodoRaiz);


            rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "data"));
            LlenarTreeView(rutaProyecto, nodoRaiz);

            treeView1.AfterSelect += treeView1_AfterSelect;
            listView1.ItemActivate += listView1_ItemActivate;

        }

        private void LlenarTreeView(string carpetaPadre, TreeNode nodoPadre)
        {
            try
            {
                // Obtener subcarpetas
                string[] subcarpetas = Directory.GetDirectories(carpetaPadre);


                // Agregar subcarpetas al TreeView
                foreach (string subcarpeta in subcarpetas)
                {

                    string ruta = Path.Combine(carpetaPadre, subcarpeta).Replace(rutaProyecto, "");
                    TreeNode nodoHijo = new TreeNode(Path.GetFileName(subcarpeta));

                    nodoHijo.Tag = ruta;
                    nodoHijo.ImageIndex = 0;    
                    nodoPadre.Nodes.Add(nodoHijo);
                    LlenarTreeView(subcarpeta, nodoHijo); // Llenar subcarpetas recursivamente
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, como imprimir información de depuración o registrar el error
                Console.WriteLine($"Error: {ex.Message}");
                MessageBox.Show($"Error de acceso: {ex.Message}", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }



        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //elimiar los nodos hijos del nodo seleccionado
            e.Node.Nodes.Clear();

            string ruta = e.Node.Tag.ToString().Replace("/", "\\");
            string path = Path.Combine(rutaProyecto, ruta);
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {

                    if (dir.FullName.StartsWith(rutaProyecto))
                    {
                        string FullName = dir.FullName.Replace(rutaProyecto, "");
                        Console.WriteLine("FullName: " + FullName);
                        TreeNode node = new TreeNode(dir.Name);

                        node.Tag = FullName;

                        e.Node.Nodes.Add(node);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error de acceso: {ex.Message}", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Manejar excepción si no se tiene acceso a los archivos
                MessageBox.Show("No tienes acceso a los archivos de esta carpeta.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



            string dirInfo = e.Node.Tag.ToString().Replace("/", "\\");
            Console.WriteLine("dirInfo: " + dirInfo);
            Console.WriteLine("dirInfo: " + "D:\\Algoritmos paralelos\\OS_BTC\\OS_BTC\\data\\systen33\\multimedia");



            if (dirInfo.StartsWith("\\")) dirInfo = dirInfo.Substring(1);

            if (e.Node.FullPath == "Proyecto")
            {   
                MostrarElementos("");
                historialDeRutas.Clear();
            }
            else
            {
                historialDeRutas.Push(dirInfo);
                MostrarElementos(dirInfo);
            }


            //MostrarElementos("");
        }

        //funciones para mostrar los elementos de dirInfo por consola





        private void listView1_ItemActivate(object sender, EventArgs e)
        {



            if (listView1.SelectedItems.Count > 0)
            {
                System.Windows.Forms.ListViewItem selectedItem = listView1.SelectedItems[0];


                if (selectedItem.SubItems[1].Text == "Carpeta")
                {
                    if (historialDeRutas.Count > 0)
                    {
                        string nuevaRuta = Path.Combine(historialDeRutas.Peek(), selectedItem.Text);
                        historialDeRutas.Push(nuevaRuta);
                    }
                    else
                    {
                        historialDeRutas.Push(selectedItem.Text);
                    }
                    MostrarElementos(historialDeRutas.Peek());
                }else if (selectedItem.SubItems[1].Text == "Archivo de Texto")
                {
                    string ruta = Path.Combine(rutaProyecto, historialDeRutas.Peek(), selectedItem.Text);
                    Home.btn_abrir_nota_Click(ruta);
                    
                }
                else if (selectedItem.SubItems[1].Text == "Archivo Audio")
                {
                    string ruta = Path.Combine(rutaProyecto, historialDeRutas.Peek(), selectedItem.Text);
                    Console.WriteLine("Ruta: " + ruta);
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(ruta);
                    player.Play();
                }
                else if (selectedItem.SubItems[1].Text == "Archivo Multimedia")
                {
                    string ruta = Path.Combine(rutaProyecto, historialDeRutas.Peek(), selectedItem.Text);
                    Console.WriteLine("Ruta: " + ruta);
                    System.Diagnostics.Process.Start(ruta);
                }
                else
                {
                    MessageBox.Show("No se puede abrir el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //MostrarHistorialEnConsola();
        }

        /* private void MostrarHistorialEnConsola()
         {
             Console.WriteLine("Historial de rutas:");
             foreach (string ruta in historialDeRutas)
             {
                 Console.WriteLine(ruta);
             }
         }*/


        private void MostrarElementos(string ruta)
        {
            listView1.Items.Clear();
            lavel_ruta.Text = "Data\\" + ruta;

            string path = Path.Combine(rutaProyecto, ruta);
            Console.WriteLine("MostrarElementos: " + Path.Combine(rutaProyecto, ruta));
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                foreach (FileSystemInfo item in dirInfo.GetFileSystemInfos())
                {
                    System.Windows.Forms.ListViewItem listItem = new System.Windows.Forms.ListViewItem(item.Name);

                    if (item is DirectoryInfo)
                    {
                        listItem.SubItems.Add("Carpeta");
                        listItem.SubItems.Add(""); // Dejar el tamaño en blanco para las carpetas
                        listItem.ImageIndex = 0;
                    }
                    else if (item is FileInfo)
                    {
                        string extension = ((FileInfo)item).Extension.ToLower();

                        if (extension == ".txt")
                        {
                            listItem.SubItems.Add("Archivo de Texto");
                            listItem.ImageIndex = 1;
                        }
                        else if (extension == ".mp3" )
                        {
                            listItem.SubItems.Add("Archivo Audio");
                            listItem.ImageIndex = 2;
                        }
                        else if (extension == ".mp4" || extension == ".avi")
                        {
                            listItem.SubItems.Add("Archivo Multimedia");
                            listItem.ImageIndex = 3;
                        }
                        else
                        {
                            listItem.SubItems.Add("Archivo");
                        }

                        listItem.SubItems.Add(((FileInfo)item).Length.ToString());
                       
                    }
                    else
                    {
                        listItem.SubItems.Add("Desconocido");
                        listItem.SubItems.Add("");
                    }

                    listView1.Items.Add(listItem);
                }



            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error de acceso: {ex.Message}", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (historialDeRutas.Count > 1)
            {
                historialDeRutas.Pop();  // Eliminar la ruta actual del historial
                string rutaAnterior = historialDeRutas.Peek();  // Obtener la ruta anterior sin eliminarla del historial
                MostrarElementos(rutaAnterior);
            }
            else if (historialDeRutas.Count == 1)
            {
                historialDeRutas.Pop();
                MostrarElementos("");
            }
        }
       
        private void CrearCarpetaButton_Click(object sender, EventArgs e)
        {
            using (mensaje mensajeForm = new mensaje())
            {
                mensajeForm.StartPosition = FormStartPosition.CenterScreen;
                if (mensajeForm.ShowDialog() == DialogResult.OK)
                {
                    string nombreCarpeta = mensajeForm.text_name.Text;
                    if (!string.IsNullOrEmpty(nombreCarpeta))
                    {
                        string rut = historialDeRutas.Count > 0 ? historialDeRutas.Peek() : "";
                        string ruta = Path.Combine(rutaProyecto, rut, nombreCarpeta);
                        if (!Directory.Exists(ruta))
                        {
                            try
                            {
                                Directory.CreateDirectory(ruta);
                                MostrarElementos(rut);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al crear la carpeta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La carpeta ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxVistas.SelectedIndex)
            {
                case 0:
                    listView1.View = View.Details;
                    break;
                case 1:
                    listView1.View = View.LargeIcon;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.List;
                    break;
                case 4:
                    listView1.View = View.Tile;
                    break;
                default:
                    break;
            }
        }
    }
}
