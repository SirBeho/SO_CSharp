using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using NAudio.Wave;
using System.IO;
using System.Xml.Linq;

using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;



namespace OS_BTC
{
    public partial class Multimedia : Form
    {
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFile;
        private string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "data"));
        private bool mute = false;
        private double volumen = 100;


       

        // Define la clase Categoria directamente en el formulario
        public class Listas_reproduccion
        {
            public string Nombre { get; set; }
            public List<string> Canciones { get; set; }
        }

        private List<Listas_reproduccion> Listas;


        public Multimedia()
        {
            InitializeComponent();
            wavePlayer = new WaveOutEvent();
            wavePlayer.Volume = 1f;

            CargarListas();

           
            
        



        }

        private void CargarListas()
        {

               string ruta = "D:/Algoritmos paralelos/OS_BTC/OS_BTC/data/systen33/multimedia/listas.json";
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string json = sr.ReadToEnd();
                    Listas = JsonConvert.DeserializeObject<List<Listas_reproduccion>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
            }

            comboBoxListas.Items.Clear();

            foreach (var Lista in Listas)
            {
                comboBoxListas.Items.Add(Lista.Nombre);
            }

           
            // También puedes establecer un valor predeterminado si lo deseas
            if (comboBoxListas.Items.Count > 0)
            {
                comboBoxListas.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            }


        }


        private void ComboBoxListas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listas_reproduccion listaSeleccionada = Listas[comboBoxListas.SelectedIndex];

            // Limpia el ListView antes de agregar nuevas canciones
            
            groupBox1.Text = listaSeleccionada.Nombre;
            listViewCanciones.Items.Clear();
            
            // Agrega cada canción al ListView
            foreach (string direccionCompleta in listaSeleccionada.Canciones)
            {
                // Obtén solo el nombre del archivo de la dirección completa
                string nombreCancion = Path.GetFileName(direccionCompleta);
                // Crea un ListViewItem con el nombre de la canción
                ListViewItem item = new ListViewItem(nombreCancion);

                // Almacena la dirección completa como Tag del ListViewItem
                item.Tag = direccionCompleta;
              
                // Agrega el ListViewItem al ListView
                listViewCanciones.Items.Add(item);
            }
        }


        private void listViewCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine("Cancion seleccionada");
            // Verifica si hay algún ítem seleccionado en el ListView
            if (listViewCanciones.SelectedItems.Count > 0)
            {
                   
                // Obtiene la dirección completa de la canción desde el Tag
                string dirInfo = rutaProyecto+ listViewCanciones.SelectedItems[0].Tag.ToString();
                Console.WriteLine(dirInfo);

                // Configura el reproductor con la dirección completa
                PlayCancion(dirInfo);
            }
        }


        private void PlayCancion(string dirInfo)
        {
            if (dirInfo.Contains(".mp3") || dirInfo.Contains(".wav"))
            {
                try
                {
                    if (audioFile != null)
                    {
                        wavePlayer.Stop();
                        wavePlayer.Dispose();
                        audioFile.Dispose();
                    }

                    audioFile = new AudioFileReader(dirInfo);
                    wavePlayer.Init(audioFile);
                    btn_play.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
                    dir_music.Text = dirInfo.Replace(rutaProyecto, "");
                    name_music.Text = Path.GetFileName(dirInfo);

                    lblDuracionTotal.Text = audioFile.TotalTime.ToString(@"hh\:mm\:ss");

                    trackBarPosicion.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No es un archivo de audio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                if (wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    wavePlayer.Pause();
                    timer1.Stop();
                    btn_play.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
                }
                else 
                {
                    wavePlayer.Play();
                    timer1.Start();
                    btn_play.IconChar = FontAwesome.Sharp.IconChar.Pause;
                }
               
               
            }
        }

        

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                wavePlayer.Stop();
                timer1.Stop();
                btn_play.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
                audioFile.CurrentTime = TimeSpan.MaxValue;
            }
        }

        private void trackBarPosicion_Scroll(object sender, EventArgs e)
        {
            // Ajustar la posición de reproducción según la posición del TrackBar
            audioFile.CurrentTime = TimeSpan.FromSeconds(trackBarPosicion.Value);
            Console.WriteLine(trackBarPosicion.Value);
            Console.WriteLine(TimeSpan.FromSeconds(trackBarPosicion.Value));
        }

       

        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detener y liberar recursos al cerrar el formulario
            if (wavePlayer != null)
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPosicionActual.Text = audioFile.CurrentTime.ToString(@"hh\:mm\:ss");
            trackBarPosicion.Value = (int)audioFile.CurrentTime.TotalSeconds;
        }

        private void btn_mute_click(object sender, EventArgs e)
        {
            mute = !mute;

            trackBar1_Scroll(null, null);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

           
            wavePlayer.Volume =  ((float)vol_bar.Value) / 100;
          
            volumen = ((float)vol_bar.Value) / 100;
        
            txt_volumen.Text = vol_bar.Value.ToString() + "%";



            if (mute || volumen == 0)
            {
                wavePlayer.Volume = 0f;
                btn_mute.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;

            }
            else if (volumen < 0.33f)
            {
                btn_mute.IconChar = FontAwesome.Sharp.IconChar.VolumeOff;
            }
            else if (volumen < 0.66f)
            {
                btn_mute.IconChar = FontAwesome.Sharp.IconChar.VolumeLow;
            }
            else
            {
                btn_mute.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                lblPosicionActual.Text = "00:00:00";
                trackBarPosicion.Value = 0;
                wavePlayer.Stop();
                timer1.Stop();
                btn_play.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
                audioFile.CurrentTime = TimeSpan.Zero;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            { 
                audioFile.CurrentTime = audioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
            }

        }

        private void adelante_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = audioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            using (Explorar explorar = new Explorar())
            {
                
                explorar.Text = string.Empty;
                explorar.Owner = this;
                

                if (explorar.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la respuesta del cuadro de diálogo
                    PlayCancion(explorar.cancionSeleccionada);
                    
                }
                else
                {
                    
                   Console.WriteLine("No se selecciono ninguna cancion");
                }

            }
        }
    }
}
