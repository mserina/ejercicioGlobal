using ejercicioGlobal.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioGlobal.utilidades
{
    internal class idGenerator
    {
        public long idGeneratorP(List<bibliotecaDto> bibliotecas)
        {
            long nuevoId;
            int tamañoLista = bibliotecas.Count;

            if (tamañoLista > 0)
            {
                nuevoId = bibliotecas[bibliotecas.Count - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }

        public long idGeneratorC(List<bibliotecaDto> bibliotecas)
        {
            long nuevoId;
            int tamañoLista = bibliotecas.Count;

            if (tamañoLista > 0)
            {
                nuevoId = bibliotecas[bibliotecas.Count - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }

        public long idGeneratorL(List<bibliotecaDto> bibliotecas)
        {
            long nuevoId;
            int tamañoLista = bibliotecas.Count;

            if (tamañoLista > 0)
            {
                nuevoId = bibliotecas[bibliotecas.Count - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }

        public long idGeneratorB(List<bibliotecaDto> bibliotecas)
        {
            long nuevoId;
            int tamañoLista = bibliotecas.Count;

            if (tamañoLista > 0)
            {
                nuevoId = bibliotecas[bibliotecas.Count - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;
        }
    }
}
