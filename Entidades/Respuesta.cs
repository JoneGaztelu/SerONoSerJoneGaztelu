using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Respuesta
    {
        public Respuesta()
        {
        }

        public Respuesta(int numRespuesta)
        {
            NumRespuesta = numRespuesta;
        }

        public Respuesta(int numPregunta, int numRespuesta, string posibleRespuesta, bool valida) : this(numPregunta)
        {
            NumRespuesta = numRespuesta;
            PosibleRespuesta = posibleRespuesta;
            Valida = valida;
        }

        public int NumPregunta { get; set; }
        public int NumRespuesta { get; set; }
        public string PosibleRespuesta { get; set; }
        public bool Valida { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Respuesta respuesta &&
                   NumRespuesta == respuesta.NumRespuesta;
        }

        public override int GetHashCode()
        {
            return -428158993 + NumRespuesta.GetHashCode();
        }
    }
}
