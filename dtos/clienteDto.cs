using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.dtos
{
    /// <summary>
    /// Donde se almacena los atributos y metodos de la clase biblioteca
    /// msm - 070424
    /// </summary>
    internal class clienteDto
    {
        //Cotroladores 
        long id;
        string nombre;
        string apellidos;
        string fechaDeNacimiento;
        string DNI;
        string correoElectrónico;
        DateTime fechaInicioSuspensión;
        DateTime fechaFinSuspensión;


        //Getters Setters
        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string CorreoElectrónico { get => correoElectrónico; set => correoElectrónico = value; }
        public DateTime FechaInicioSuspensión { get => fechaInicioSuspensión; set => fechaInicioSuspensión = value; }
        public DateTime FechaFinSuspensión { get => fechaFinSuspensión; set => fechaFinSuspensión = value; }



        //Controladores
        public clienteDto(long id, string nombre, string apellidos, string fechaDeNacimiento, string DNI, string correoElectrónico)
        {
            prestamoDto prestamo = new prestamoDto();
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.DNI = DNI;
            this.correoElectrónico = correoElectrónico;
            this.fechaInicioSuspensión = prestamo.FechaEntrega.AddDays(1);
            this.fechaFinSuspensión = fechaInicioSuspensión.AddDays(7);
        }

        public clienteDto()
        {
        }

        //toString

    }
}
