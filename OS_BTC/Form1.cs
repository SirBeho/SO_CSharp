using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_BTC
{
    public partial class Form1 : Form
    {

        private int panelWinMenutop;
        private Timer animacionTimer = new Timer();
        
        private bool isPanelVisible = true;
       

        public Form1 home { get; set; }

        public Form1()
        {
            InitializeComponent();


            Console.WriteLine("Hola Mundo");
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            this.Text = "Sistema Operativo"; // Titulo de la ventana
           // this.MaximizeBox = true; // Deshabilita el boton de maximizar
            //this.MinimizeBox = false; // Deshabilita el boton de minimizar
            //this.ControlBox = false;
           

            panel_WinMenu.Top = this.ClientSize.Height;
            this.StartPosition = FormStartPosition.CenterScreen; // Centra el form en la pantalla
            this.Size = new Size(1124, 800); // Tamaño del form
            this.Resize += Form_Resize; // Evento que se dispara cuando el form es redimencionado
            Form_Resize(Owner, EventArgs.Empty);
            Panel_home_Resize(Owner, EventArgs.Empty);
           
           
            panel_WinMenu.SizeChanged += Panel_home_Resize;




           


         
            
        
           

        }

       


        private void Form_Resize(object sender, EventArgs e)
        {
           panel_BarraTareas.Height = (int)(this.ClientSize.Height * 0.065);
            btn_Home.Width = btn_Home.Height;

            panel_WinMenu.Width = (int)(this.ClientSize.Width * 0.35);
            panel_WinMenu.Height = (int)(this.ClientSize.Height * 0.75);
            panel_WinMenu.Left = 15;

            RoundCorners(panel_WinMenu, 20);
            panelWinMenutop = panel_WinMenu.Top  = this.ClientSize.Height - panel_WinMenu.Height - panel_BarraTareas.Height - 5;  // 20 es la distancia del borde inferior
       
        }

        private void Panel_home_Resize(object sender, EventArgs e)
        {
            //el boton siempre estara en el centro del panel
            btn_Exit.Location = new System.Drawing.Point((panel_WinMenu.Width - btn_Exit.Width) - 4, (panel_WinMenu.Height - btn_Exit.Height) - 4);

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            animacionTimer.Stop();
            animacionTimer.Tick -= Animacion_Tick;

            animacionTimer.Interval = 10;

            animacionTimer.Tick += Animacion_Tick;

            animacionTimer.Start();
        }
        public void RoundCorners(Control control, int cornerRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(control.DisplayRectangle.X, control.DisplayRectangle.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(control.DisplayRectangle.Width - cornerRadius, control.DisplayRectangle.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(control.DisplayRectangle.Width - cornerRadius, control.DisplayRectangle.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(control.DisplayRectangle.X, control.DisplayRectangle.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            control.Region = new System.Drawing.Region(path);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void Animacion_Tick(object sender, EventArgs e)
        {
            if (isPanelVisible)
            {
                if (panel_WinMenu.Top < this.ClientSize.Height)
                {
                    panel_WinMenu.Top += 75;
                    panel_WinMenu.Invalidate();
                }
                else
                {
                    animacionTimer.Stop();
                    isPanelVisible = false;
               
                    panel_WinMenu.Top = this.ClientSize.Height;
                  

                    animacionTimer.Tick -= Animacion_Tick;
                    animacionTimer.Stop(); // Detén el temporizador cuando la animación ha terminado
                    panel_WinMenu.Invalidate();
                }
              
            }
            else
            {

                
                if (panel_WinMenu.Top > panelWinMenutop)
                {
                    panel_WinMenu.Top -= 75;
                    
                }
                else
                {
                    animacionTimer.Stop();
                    panel_WinMenu.Top = panelWinMenutop;
                    panel_WinMenu.Invalidate();
    

                    isPanelVisible = true;
                    animacionTimer.Tick -= Animacion_Tick;
                    animacionTimer.Stop(); // Detén el temporizador cuando la animación ha terminado
                }
            }
            panel_WinMenu.Invalidate();
        }

        private void Abrir_Explorador(object sender, EventArgs e)
        {
            cerrar_menu(sender, e);

           ExploradorArchivos  carpeta = new ExploradorArchivos(this);
            //carpeta.StartPosition = FormStartPosition.Manual;
           // carpeta.Location = new Point(this.Location.X + 50, this.Location.Y + 50);
           carpeta.TopLevel = false;
            // Establecer el formulario padre como propietario
            panel_desktop.Controls.Add(carpeta);

            // Mostrar el ExploradorArchivosForm
            carpeta.Show();
        }

        private void cerrar_menu(object sender, EventArgs e)
        {

            if (isPanelVisible)
            {
                animacionTimer.Stop();
                animacionTimer.Tick -= Animacion_Tick;

                animacionTimer.Interval = 10; // Establece el intervalo del temporizador a 10 milisegundos

                animacionTimer.Tick += Animacion_Tick;

                animacionTimer.Start();
            }

        } 

        private void btn_abr_nota_Click(object sender, EventArgs e)
        {
            
            btn_abrir_nota_Click("");
        }

        public void btn_abrir_nota_Click(string ruta)
        {
            cerrar_menu(null, null);

            BlocNotas blocNotas = new BlocNotas(this, ruta);

            blocNotas.TopLevel = false;

            panel_desktop.Controls.Add(blocNotas);
            blocNotas.BringToFront();
            blocNotas.Show();

        }

        private void btn_abr_multimedia_Click(object sender, EventArgs e)
        {
            cerrar_menu(null, null);

            Multimedia multimedia = new Multimedia();
            multimedia.TopLevel = false;
            panel_desktop.Controls.Add(multimedia);
            multimedia.BringToFront();
            multimedia.Show();

        }
    }



}
