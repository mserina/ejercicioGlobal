using ejercicioGlobal.dtos;
using ejercicioGlobal.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos de operacion
    /// msm - 070424
    /// </summary>

    
    internal class OperacionImplementacion : OperacionInterfaz
    {

       idGenerator idGenerator2 = new idGenerator();
        public void darAltaBiblioteca(List<bibliotecaDto> bibliotecas)
        {
            Console.WriteLine("Inserte el nombre de la biblioteca");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserte el nombre de la biblioteca");
            string direccion = Console.ReadLine();
            long id = idGenerator2.idGeneratorB(bibliotecas);

            bibliotecaDto bibliotecaNueva = new bibliotecaDto(id, nombre, direccion);
            bibliotecas.Add(bibliotecaNueva);

            List<clienteDto> cliente
        }

        /*
        public void darAltaCliente()
        {

        }

        public void darAltaPrestamo()
        {

        }

        public void darAltaLibro()
        {

        }
        */
    }
}
