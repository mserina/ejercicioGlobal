using ejercicioGlobal.dtos;
using ejercicioGlobal.servicios;
using System.IO;

namespace ejercicioGlobal
{
    /// <summary>
    /// Clase principal del programa 
    /// msm - 070424
    /// </summary>
    class Program
    {

        /// <summary>
        /// Metodo que contiene el procedimiento del programa
        /// msm - 070424
        /// </summary>
        /// <param name="args"></param>

        string rutaArchivo = "C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\registroSea";
        StreamWriter sw;
        StreamReader sr;
        static public void Main(String[] args)
        {
            List<bibliotecaDto> bibliotecas = new List<bibliotecaDto>();
            bool cerrarMenu = false;
            int opcionRespuesta;
            MenuInterfaz menu = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            while(!cerrarMenu) 
            {
                opcionRespuesta = menu.opcionYMostrarMenu();

                try
                {
                    switch (opcionRespuesta)
                    {
                        case 0:
                            cerrarMenu=true;
                            break;
                        case 1:
                             op.darAltaBiblioteca(bibliotecas);
                            break;
                        case 2:
                            op.darAltaCliente();
                            break;
                        case 3:
                            op.darAltaLibro();
                            break;
                        case 4:
                            op.darAltaPrestamo();
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}