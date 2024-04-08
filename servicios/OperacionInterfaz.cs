using ejercicioGlobal.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos de operacion
    /// msm - 070424
    /// </summary>
    internal interface OperacionInterfaz
    {
        public void darAltaBiblioteca(List<bibliotecaDto> bibliotecas);

        
        public void darAltaCliente(List<bibliotecaDto> bibliotecas);
        /*
        public void darAltaPrestamo();

        public void darAltaLibro();
        */
    }
}
