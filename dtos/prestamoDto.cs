using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.dtos
{
    /// <summary>
    /// Donde se almacena los atributos y metodos de la clase biblioteca
    /// msm - 070424
    /// </summary>
    /// 

    internal class prestamoDto
    {
       

        //Cotroladores 
        long idPrestamo;
        long idCliente;
        long idLibro;
        DateTime fechaPrestamo;
        DateTime fechaEntrega;
        string estadoPrestamo;


        //Getters Setters
        public long IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public long IdLibro { get => idLibro; set => idLibro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }


        //Controladores
        clienteDto clientes = new clienteDto();
        librosDto libros = new librosDto(); 

        public prestamoDto(long idPrestamo, long idCliente, long idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estadoPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.idCliente = clientes.Id;
            this.idLibro = libros.Id;
            this.fechaPrestamo = DateTime.Now.AddDays(1);
            this.fechaEntrega = fechaPrestamo.AddDays(7);
            this.estadoPrestamo = estadoPrestamo;
        }

        public prestamoDto()
        {
        }



        //toString
    }
}
