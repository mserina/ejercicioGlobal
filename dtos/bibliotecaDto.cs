using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.dtos
{
    /// <summary>
    /// Donde se almacena los atributos y metodos de la clase biblioteca
    /// msm - 070424
    /// </summary>
    internal class bibliotecaDto
    {
        //Cotroladores 
        long id;
        string nombreBiblioteca;
        string direccion;
        private List<clienteDto> clientesLista;
        private List<prestamoDto> prestamosLista;
        private List<librosDto> librosLista;
        public string rutaArchivo = "C:\\Users\\Usuario\\Desktop\\ARCHIVOS\\registroSea";

        //Getters Setters

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<clienteDto> ClientesLista { get => clientesLista; set => clientesLista = value; }
        internal List<prestamoDto> PrestamosLista { get => prestamosLista; set => prestamosLista = value; }
        internal List<librosDto> LibrosLista { get => librosLista; set => librosLista = value; }


        //Controladores
        public bibliotecaDto(long id, string nombreBiblioteca, string direccion)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccion = direccion;
            clientesLista = new List<clienteDto>();
            prestamosLista = new List<prestamoDto>();
        }

        public bibliotecaDto()
        {

        }

        //METODO APARTE
        public void AgregarCliente(clienteDto clientes)
        {
            ClientesLista.Add(clientes); 
        }

        public void AgregarPrestamo(prestamoDto prestamos)
        {
            PrestamosLista.Add(prestamos);
        }

        public void AgregarLibro(librosDto libro)
        {
            librosLista.Add(libro);
        }

        /*
        public void abrirArchivo(StreamWriter sw)
        {
            using (sw = new StreamWriter(rutaArchivo))
            {
                sw
            }
        }
        */

    }
}
