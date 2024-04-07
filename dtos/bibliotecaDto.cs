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
    internal class bibliotecaDto
    {
        //Cotroladores 
        long id;
        string nombreBiblioteca;
        string direccion;

        //Getters Setters

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string Direccion { get => direccion; set => direccion = value; }



        //Controladores
        public bibliotecaDto(long id, string nombreBiblioteca, string direccion)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccion = direccion;
        }

        public bibliotecaDto()
        {

        }



    }
}
