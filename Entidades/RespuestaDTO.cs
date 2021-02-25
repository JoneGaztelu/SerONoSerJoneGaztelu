﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RespuestaDTO
    {
        public RespuestaDTO()
        {
        }

        public RespuestaDTO(string posibleRespuesta, string explicacion, bool valida)
        {
            PosibleRespuesta = posibleRespuesta;
            Explicacion = explicacion;
            Valida = valida;
        }

        public RespuestaDTO(int numPregunta, int numRespuesta, string posibleRespuesta, bool valida, string explicacion)
        {
            NumPregunta = numPregunta;
            NumRespuesta = numRespuesta;
            PosibleRespuesta = posibleRespuesta;
            Valida = valida;
            Explicacion = explicacion;
        }

        public int NumPregunta { get; set; }
        public int NumRespuesta { get; set; }
        public string PosibleRespuesta { get; set; }
        public bool Valida { get; set; }

        public string Explicacion { get; set; }

    }
}
