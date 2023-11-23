using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                opcion = Pantallas.PantallaPrincipal();

                switch (opcion)
                {
                    case 1:
                        Pantallas.Satisfaccion();
                        break;
                    case 2:
                        Pantallas.VerDatosRegistrados();
                        break;
                    case 3:
                        Pantallas.EliminarDato();
                        break;
                    case 4:
                        Pantallas.OrdenarDatos();
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 5);
        }
    }
}
