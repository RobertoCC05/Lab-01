using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstraccion
{
    public class Auto :IAuto
    {
        public string Modelo { get; set; }
        public int Anho { get; set; }
        
        public Auto() { }
        public void Encender()
        { Console.WriteLine("Encendido"); }
        public void Apagar()
        {  Console.WriteLine("Apagado"); }
        public void Acelerar() { Console.WriteLine("Acelereando..."); }
        public void Frenar() { Console.WriteLine("Frenando..."); }
    }
}
