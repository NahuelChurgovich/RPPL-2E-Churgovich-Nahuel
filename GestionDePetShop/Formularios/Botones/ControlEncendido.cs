using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Formularios.Botones
{
   public class ControlEncendido : CheckBox
    {
        #region Atributos
        private Color fondoEncendidoColor = Color.MediumSlateBlue;
        private Color barraEncendidaColor = Color.WhiteSmoke;
        private Color fondoApagadoColor = Color.Gray;
        private Color barraApagadaColor = Color.Gainsboro;
        private bool estiloSolido = true;
        #endregion


        #region Propiedades

        [Category("Control Encendido Avanzado")]
        public Color FondoEncendidoColor
        {
            get
            {
                return fondoEncendidoColor;
            }

            set
            {
                fondoEncendidoColor = value;
                this.Invalidate();
            }
        }

        [Category("Control Encendido Avanzado")]
        public Color BarraEncendidaColor
        {
            get
            {
                return barraEncendidaColor;
            }

            set
            {
                barraEncendidaColor = value;
                this.Invalidate();
            }
        }

        [Category("Control Encendido Avanzado")]
        public Color FondoApagadoColor
        {
            get
            {
                return fondoApagadoColor;
            }

            set
            {
                fondoApagadoColor = value;
                this.Invalidate();
            }
        }

        [Category("Control Encendido Avanzado")]
        public Color BarraApagadaColor
        {
            get
            {
                return barraApagadaColor;
            }

            set
            {
                barraApagadaColor = value;
                this.Invalidate();
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {

            }
        }

        [Category("Control Encendido Avanzado")]
        [DefaultValue(true)]
        public bool EstiloSolido
        {
            get
            {
                return estiloSolido;
            }

            set
            {
                estiloSolido = value;
                this.Invalidate();
            }
        }
        #endregion

        #region Constructores
        public ControlEncendido()
        {
            this.MinimumSize = new Size(35, 12);
        }
        #endregion

        #region Métodos
        private GraphicsPath GetRutaFigura()
        {
            int arcSize = this.Height - 1;
            Rectangle arcoIzquierdo = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle arcoDerecho = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(arcoIzquierdo, 90, 180);
            path.AddArc(arcoDerecho, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int tamanioBarra = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //dibujando fondo del control
                if (estiloSolido)
                    pevent.Graphics.FillPath(new SolidBrush(fondoEncendidoColor), GetRutaFigura());
                else pevent.Graphics.DrawPath(new Pen(fondoEncendidoColor, 2), GetRutaFigura());
                //dibujando barra
                pevent.Graphics.FillEllipse(new SolidBrush(barraEncendidaColor),
                    new Rectangle(this.Width - this.Height + 1, 2, tamanioBarra, tamanioBarra));
            }
            else //OFF
            {
                //dibujando fondo del control
                if (estiloSolido)
                    pevent.Graphics.FillPath(new SolidBrush(fondoApagadoColor), GetRutaFigura());
                else pevent.Graphics.DrawPath(new Pen(fondoApagadoColor, 2), GetRutaFigura());
                //dibujando barra
                pevent.Graphics.FillEllipse(new SolidBrush(barraApagadaColor),
                    new Rectangle(2, 2, tamanioBarra, tamanioBarra));
            }
        }
        #endregion



    }
}
