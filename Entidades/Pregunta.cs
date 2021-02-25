 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta
    {
        public Pregunta()
        {
        }

        public Pregunta(int numPregunta, string enunciado, int nivel)
        {
            NumPregunta = numPregunta;
            Enunciado = enunciado;
            Nivel = nivel;
        }

        public int NumPregunta { get; set; }
        public string Enunciado { get; set; }
        public int Nivel { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Pregunta pregunta &&
                   NumPregunta == pregunta.NumPregunta;
        }

        public override int GetHashCode()
        {
            return -2028783955 + NumPregunta.GetHashCode();
        }
    }
}
