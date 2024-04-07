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
    internal class librosDto
    {
        //Cotroladores 
        long id;
        string titulo;
        string subtitulo;
        string autor;
        string ISBN;
        int numeroEdicion;
        string editorial;
        int stock;

        //Getters Setters
        public long Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int NumeroEdicion { get => numeroEdicion; set => numeroEdicion = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Stock { get => stock; set => stock = value; }



        //Controladores
        public librosDto(long id, string titulo, string subtitulo, string autor, string iSBN, int numeroEdicion, string editorial, int stock)
        {
            this.id = id;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.autor = autor;
            this.ISBN = iSBN;
            this.numeroEdicion = numeroEdicion;
            this.editorial = editorial;
            this.stock = stock;
        }

        public librosDto()
        {
        }



        //toString
    }
}
