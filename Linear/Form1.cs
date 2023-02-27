using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear
{
    public partial class Form1 : Form
    {
        public const double x1 = 0;
        public const double y1 = 0;
        public const double x2 = 0;
        public const double y2 = 0;
        Graphics dibujo;
        public Form1()
        {
            InitializeComponent();
            dibujo = CreateGraphics();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(txt_X1.Text);
                double y1 = double.Parse(txt_Y1.Text);
                double x2 = double.Parse(txt_X2.Text);
                double y2 = double.Parse(txt_Y2.Text);
                clsLinea rec = new clsLinea(x1,y1,x2,y2);
                dibujo.FillRectangle(Brushes.Red, rec.colocaX1(), rec.colocaY1(), rec. colocaX2(), rec.colocaY2());
                txtContador.Text = Convert.ToString(clsLinea.cuentaLineas());   
            }
            catch
            {
                MessageBox.Show("No has colocado las coordenadas en uno o varios puntos");
            }
        }
    }
}
