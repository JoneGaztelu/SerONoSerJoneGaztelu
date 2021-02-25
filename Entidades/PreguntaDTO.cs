using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PreguntaDTO
    {
        public PreguntaDTO()
        {
        }

        public PreguntaDTO(int numPregunta, string enunciado, int nivel, List<RespuestaDTO> listaRespuestas)
        {
            NumPregunta = numPregunta;
            Enunciado = enunciado;
            Nivel = nivel;
            ListaRespuestas = listaRespuestas;
        }

        public int NumPregunta { get; set; }
        public string Enunciado { get; set; }
        public int Nivel { get; set; }

        public List<RespuestaDTO> ListaRespuestas { get; set; }
    }
}
