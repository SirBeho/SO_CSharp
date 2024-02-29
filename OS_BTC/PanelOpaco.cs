using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_BTC
{
    internal class PanelOpaco: Panel
    {
        private float opacidad = 1.0f; // Valor de opacidad predeterminado

        public float Opacidad
        {
            get { return opacidad; }
            set
            {
                if (value >= 0.0f && value <= 1.0f)
                {
                    opacidad = value;
                    Invalidate(); // Invalida el área del panel para que se vuelva a dibujar
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Opacidad debe estar entre 0 y 1." + value);
                }
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var brush = new SolidBrush(Color.FromArgb((int)(opacidad * 255), this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
    
}

