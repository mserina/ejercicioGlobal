using ejercicioGlobal.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos de Menu
    /// msm - 070424
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Recoge la respuesta del usuario y muestra el menu por pantalla
        /// msm - 070424
        /// </summary>
        /// <returns></returns>
        public int opcionYMostrarMenu();

    }
}
