using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Linear
{
    internal class clsLinea
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private static int contar = 0;
        clsLinea()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }
        public clsLinea(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public clsLinea(double x1, double y1, double x2, double y2)
        {
            this.x1 = (int)x1;
            this.y1 = (int)y1;
            this.x2 = (int)x2;
            this.y2 = (int)y2;
        }
        public int colocaX1()
        {
            return x1;
        }
        public int colocaY1()
        {
            return y1;
        }
        public int colocaX2()
        {
            return x2;
        }
        public int colocaY2()
        {
            return y2;
        }
        public int cambiarX1(int x1)
        {
            return this.x1 = x1;
        }
        public int cambiarY1(int y1)
        {
            return this.y1 = y1;
        }
        public int cambiarX2(int x2)
        {
            return this.x2 = x2;
        }
        public int cambiarY2(int y2)
        {
            return this.y2 = y2;
        }
        public static int cuentaLineas()
        {
            contar += 1;
            return contar;
        }
    }
    
    

     


        
}
