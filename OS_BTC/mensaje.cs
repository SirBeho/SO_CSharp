using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OS_BTC
{
    public partial class mensaje : Form
    {

        public string NombreCarpeta { get; private set; }
        public mensaje()
         {
            InitializeComponent();
            this.text_name.Text ="Nueva Carpeta";

            this.text_name.Focus();
            this.StartPosition = FormStartPosition.CenterScreen; // Centra el form en la pantalla
          
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AcceptButton = Ok_Button;
            this.CancelButton = Cancel_Button;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            NombreCarpeta = text_name.Text;
            if (string.IsNullOrWhiteSpace(NombreCarpeta))
            {
                this.text_name.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
    }
    
}