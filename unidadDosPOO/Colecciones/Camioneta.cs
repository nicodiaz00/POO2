using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Camioneta
    {
        public string Modelo { get; set; }
        public string Color { get; set; }

        public List<Camioneta> listaCamioneta(int valor)
        {
            List<Camioneta> listasCamionetas =new List<Camioneta>();
            for(int i = 0; i < valor; i++)
            {
                Console.WriteLine("Comience a ingresar camionetas");
            }
           
        }
    }

    
}
