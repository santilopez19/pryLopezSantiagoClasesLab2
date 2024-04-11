using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class clsPersonaje
    {
        Int32 PuntosVida { get; set; }
        String Nombre { get; set; }
        Int32 Fuerza { get; set; }
        Int32 exp { get; set; }
        Int32 resistencia { get; set; }

        private void caminar()
        {
            Console.WriteLine($"El personaje {Nombre} camino");
        }
        private void correr()
        {
            Console.WriteLine($"El personaje {Nombre} corrio y su resistencia disminuyo");
        }
        private void descansar()
        {
            Console.WriteLine($"El personaje {Nombre} descanso y su resistencia aumento");
        }
    }
}
