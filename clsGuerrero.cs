using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases 
{
    internal class clsGuerrero : clsPersonaje
    {
        Int32 Fuerza { get; set; }

        // Crear una instancia de la clase Random
        Random rnd = new Random();

        public clsGuerrero(string nombre) : base(nombre)

        private void melee()
        {
            Console.WriteLine($"El personaje {Nombre} golpeo");
        }
    }
    
}
