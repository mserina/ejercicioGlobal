using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos de menu
    /// msm - 070424
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int opcionYMostrarMenu()
        {
            int opcionSeleccionada;
            Console.WriteLine(" ");
            Console.WriteLine("0[] CERRAR MENU");
            Console.WriteLine("1[] DAR ALTA BIBLIOTECA");
            Console.WriteLine("2[] DAR ALTA CLIENTE");
            Console.WriteLine("3[] DAR ALTA LIBRO");
            Console.WriteLine("4[] DAR ALTA PRESTAMO");
            Console.WriteLine(" ");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

    }
}
