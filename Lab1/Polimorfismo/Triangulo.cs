using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Polimorfismo
{
    public class Triangulo : Figura, IFigura
    {
        public Triangulo() { }
        public void CalcularArea()
        {
            Console.WriteLine("(Lado x Lado) / 2");
        }
        public int CalcularArea(int l)
        {
            this.Lado = l;
            return (Lado * Lado) / 2;
        }
    }
}
