using ejercicioGlobal.dtos;
using ejercicioGlobal.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            
        }

        
        public void darAltaCliente(List<bibliotecaDto> bibliotecas)
        {
            Console.WriteLine("Inserte el id de la biblioteca donde quiere dar de alta al cliente");
            long idBiblioteca = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Inserte el nombre del cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserte apellido del cliente");
            string apellido = Console.ReadLine();
            Console.WriteLine("Inserte fecha de nacimiento");
            string fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Inserte los Numeros del DNI");
            int numeroDni = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte la Letra del DNI");
            string letraDireccion = Console.ReadLine();
            pedirDNI(numeroDni, letraDireccion);
            string dniCompleto = numeroDni + letraDireccion;
            Console.WriteLine("Inserte un Correo electronico");
            string correo = Console.ReadLine();

            long id = 0;
            foreach(bibliotecaDto biblioteca in bibliotecas)
            {
                if (biblioteca.Id == idBiblioteca)
                {

                    id= idGenerator2.idGeneratorC(biblioteca.ClientesLista);
                }
            }

            clienteDto clienteNuevo = new clienteDto(id, nombre, apellido, fechaNacimiento, dniCompleto, string correoElectrónico, DateTime fechaInicioSuspensión);
        }

        /*
        public void darAltaPrestamo()
        {

        }

        public void darAltaLibro()
        {

        }
        */

        private void pedirDNI(int numeroDniInsertado, string letraDniInsertado)
        {
            string[] letrasDNI = new string[23];
            letrasDNI[0] = "T";
            letrasDNI[1] = "R";
            letrasDNI[2] = "W";
            letrasDNI[3] = "A";
            letrasDNI[4] = "G";
            letrasDNI[5] = "M";
            letrasDNI[6] = "Y";
            letrasDNI[7] = "F";
            letrasDNI[8] = "P";
            letrasDNI[9] = "D";
            letrasDNI[10] = "X";
            letrasDNI[11] = "B";
            letrasDNI[12] = "N";
            letrasDNI[13] = "J";
            letrasDNI[14] = "Z";
            letrasDNI[15] = "S";
            letrasDNI[16] = "Q";
            letrasDNI[17] = "V";
            letrasDNI[18] = "H";
            letrasDNI[19] = "L";
            letrasDNI[20] = "C";
            letrasDNI[21] = "K";
            letrasDNI[22] = "E";

            int[] numeroDni = new int[23];
            numeroDni[0] = 0;
            numeroDni[1] = 1;
            numeroDni[2] = 2;
            numeroDni[3] = 3;
            numeroDni[4] = 4;
            numeroDni[5] = 5;
            numeroDni[6] = 6;
            numeroDni[7] = 7;
            numeroDni[8] = 8;
            numeroDni[9] = 9;
            numeroDni[10] = 10;
            numeroDni[11] = 11;
            numeroDni[12] = 12;
            numeroDni[13] = 13;
            numeroDni[14] = 14;
            numeroDni[15] = 15;
            numeroDni[16] = 16;
            numeroDni[17] = 17;
            numeroDni[18] = 18;
            numeroDni[19] = 19;
            numeroDni[20] = 20;
            numeroDni[21] = 21;
            numeroDni[22] = 22;

            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
             
                int DNINumeroResto = numeroDniInsertado % 23;


                if (numeroDni[DNINumeroResto] == DNINumeroResto)
                {
                    if (letraDniInsertado == letrasDNI[DNINumeroResto])
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("Ese dni no existe");
                    }
                }
                else
                {
                    Console.WriteLine("Ese dni no existe");
                }
            }
        }


    }
}
