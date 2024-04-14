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
            Console.WriteLine("Inserte el direccion de la biblioteca");
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
            /*
            string dniCompleto = pedirDNI(bibliotecas, idBiblioteca);
            */
            Console.WriteLine("Inserte DNI");
            string dniCompleto = Console.ReadLine();
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

            clienteDto clienteNuevo = new clienteDto(id, nombre, apellido, fechaNacimiento, dniCompleto, correo);

            foreach (bibliotecaDto biblioteca2 in bibliotecas)
            {
                if (biblioteca2.Id == idBiblioteca)
                {

                    biblioteca2.AgregarCliente(clienteNuevo);
                }
            }


        }

        public void verClientes(List<bibliotecaDto> bibliotecas)
        {
            Console.WriteLine("Inserte la biblioteca");
            long idBiblioteca = Convert.ToInt64(Console.ReadLine());
            foreach (bibliotecaDto biblioteca2 in bibliotecas)
            {
                if (biblioteca2.Id == idBiblioteca)
                {

                    foreach (clienteDto clientes in biblioteca2.ClientesLista)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(clientes.Id);
                        Console.WriteLine(clientes.Nombre);
                        Console.WriteLine(clientes.DNI1);

                    }
                    foreach (librosDto libros in biblioteca2.LibrosLista)
                    {
                        Console.WriteLine(libros.Titulo);
                    }

                }
            }

        }
        
        public void darAltaLibro(List<bibliotecaDto> bibliotecas)
        {
            Console.WriteLine("Inserte el id de la biblioteca donde quiere dar de alta el libro");
            long idBiblioteca = Convert.ToInt64(Console.ReadLine());

            long id = 0;
            foreach (bibliotecaDto biblioteca in bibliotecas)
            {
                if (biblioteca.Id == idBiblioteca)
                {

                    id = idGenerator2.idGeneratorL(biblioteca.LibrosLista);
                }
            }
            Console.WriteLine("Inserta el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Insertar subtitulo del libro");
            string subtitulo = Console.ReadLine();
            Console.WriteLine("Insertar autor del libro");
            string autor = Console.ReadLine();
            Console.WriteLine("Inserte el ISBN");
            string ISBN = Console.ReadLine();
            Console.WriteLine("Inserte el numero de la edicion");
            int numeroEdicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte la editorial");
            string editorial = Console.ReadLine();
            Console.WriteLine("Inserte stocks");
            int stock = Convert.ToInt32(Console.ReadLine());

            librosDto libroNuevo = new librosDto( id,  titulo,  subtitulo,  autor, ISBN,  numeroEdicion,  editorial,  stock);

            foreach (bibliotecaDto biblioteca2 in bibliotecas)
            {
                if (biblioteca2.Id == idBiblioteca)
                {

                    biblioteca2.AgregarLibro(libroNuevo);
                }
            }

        }
        
        public void darAltaPrestamo()
        {

        }
        

        /*
        private string pedirDNI(List<bibliotecaDto> bibliotecas, long idBiblioteca)
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

            string dniCompleto = "";
            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
                Console.WriteLine("Inserte numero del DNI");
                int DNINumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte letra del DNI");
                string DNILetra = Console.ReadLine();
               

                int DNINumeroResto = DNINumero % 23;


                if (numeroDni[DNINumeroResto] == DNINumeroResto)
                {
                    if (DNILetra == letrasDNI[DNINumeroResto])
                    {
                        
                        dniCompleto = DNINumero + DNILetra;

                        foreach (bibliotecaDto biblioteca2 in bibliotecas)
                        {
                            if (biblioteca2.Id == idBiblioteca)
                            {

                                foreach (clienteDto clientes in biblioteca2.ClientesLista)
                                {
                                    if(dniCompleto == clientes.DNI1)
                                    {
                                        Console.WriteLine("El DNI ya existe");
                                    }
                                    else
                                    {
                                        cerrarBucle = true;
                                    }
                                }
                            }
                        }

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

            return dniCompleto;




        }
        */
    }
}
