using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Enemigo
    {
        public int Posicion_x { get; set; }
        public int Posicion_y { get; set; }
        private int _puntos;
        public void Moverse()
        { }
        public void Disparar()
        {

        }
        public void Explotar() { }
        public int Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
                if (value >= 100)
                {
                    _puntos = value;
                }
                else
                {
                    Console.WriteLine("Introduce una puntuacion valida");
                }
            }
        }
    }
}
