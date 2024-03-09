using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Polimorfismo
{
    public class Cuadrado : Figura, IFigura
    {
        public Cuadrado() { }
        public void CalcularArea()
        {
            Console.WriteLine("Lado x Lado");
        }

        public int CalcularArea(int l) { 
            this.Lado = l;
            return Lado * Lado;
        }
        
    }
}
