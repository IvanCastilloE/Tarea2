using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemigo enemigoUno = new Enemigo();
            enemigoUno.Posicion_x = 50;
            enemigoUno.Posicion_y = 20;
            enemigoUno.Puntos = 150;
            Console.ReadLine();
        }
    }
}
