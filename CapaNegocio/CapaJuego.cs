using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CapaJuego
    {
        GestionDSet gestion = new GestionDSet(out string msj);
        List<PreguntaDTO> preg;

        public List<PreguntaDTO> ObtenerPreguntas(int nivel)
        {
            preg = gestion.ListaPreguntasNivel(nivel);

            return preg;
        }
        public PreguntaDTO DevolverPregunta(int nivel)
        {
            ObtenerPreguntas(nivel);
            Random rnd = new Random();
            int numRndPreg = rnd.Next(preg.Count);

            return preg[numRndPreg];
        }


    }
}
