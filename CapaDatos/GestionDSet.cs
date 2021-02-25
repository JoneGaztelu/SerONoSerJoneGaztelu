using CapaDatos.DsJuegoTableAdapters;
using System;
using System.Collections.Generic;
using Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GestionDSet
    {
        DsJuego dsJuego = new DsJuego();
        public GestionDSet(out string msj)
        {
            msj = LlenarTablas(out string msg);
            /*if (msj != "")
            {
                msj = "No se ha podido conectar con la base de datos";
            }*/
        }

        private string LlenarTablas(out string msj)
        {
            RespuestasTableAdapter daRespuestas = new RespuestasTableAdapter();
            PreguntasTableAdapter daPreguntas = new PreguntasTableAdapter();
            RespNoValidasTableAdapter daRespNoValidas = new RespNoValidasTableAdapter();

            try
            {
                daRespuestas.Fill(dsJuego.Respuestas);
                daPreguntas.Fill(dsJuego.Preguntas);
                daRespNoValidas.Fill(dsJuego.RespNoValidas);
                foreach (DsJuego.RespNoValidasRow respNoValida in dsJuego.RespNoValidas.Rows)
                {
                    if (respNoValida.IsExplicacionNull())
                    {
                        respNoValida.Explicacion = "Errónea, aunque no sabemos el motivo, debes investigarlo.";
                    }
                }
                //TODO control errores

                //No tenga preguntas
                if (daPreguntas == null)
                {
                    msj = "No hay preguntas, póngase en contacto con su administrador@";
                    return "";
                }

                var numPreg = dsJuego.Preguntas.Select(dr => dr.NumPregunta);

                //Preguntas que no tengan 12 respuestas
                var cantRespPreg = dsJuego.Respuestas.Count(drRes => drRes.NumPregunta.Equals(numPreg));
                if (cantRespPreg != 12)
                {
                    msj = "Hay preguntas que no tienen 12 respuestas";
                    return "";
                }

                //Que hay preguntas que no tienen la relación correcta de 8 válidas y 4 erróneas
                var cantRespPregNoVali = dsJuego.RespNoValidas.Count(drR => drR.NumPregunta.Equals(numPreg));
                var cantRespVali = dsJuego.Respuestas.Where(drR => drR.Valida).Count(drRv => drRv.NumPregunta.Equals(numPreg));
                if ((cantRespPregNoVali != 4) && (cantRespVali != 8))
                {
                    msj = "Hay preguntas que no tienen la relación correcta de 8 válidas y 4 erróneas";
                }

                //Que no hay preguntas de un nivel inferior al máximo
                /*int pregNivMax = dsJuego.Preguntas.Max(drP => drP.Nivel);
                var nivPreg = dsJuego.Preguntas.Select(dr => dr.Nivel).ToString();

                if (int.Parse(nivPreg) < pregNivMax)
                {
                    msj = "No puede haber preguntas de un nivel inferior al máximo";
                }*/
            }
            catch (Exception exc)
            {
                msj = exc.Message;
                return "";
            }
            msj = "";
            return "";
        }

        public List<PreguntaDTO> ListaPreguntasNivel(int nivel, out string msj)
        {
            //controlar nivel max y min
            var compNivMax = dsJuego.Preguntas.Max(drNivel => drNivel.Nivel);
            if (compNivMax > nivel)
            {
                msj = "No hay niveles tan altos";
                return null;
            }
            var compNivMin = dsJuego.Preguntas.Min(drNiv => drNiv.Nivel);
            if (compNivMin < nivel)
            {
                msj = "No hay niveles tan bajos";
                return null;
            }
            //TODO si hay todos nivelesç
            var todosNiveles = dsJuego.Preguntas.Select(drNivPreg => drNivPreg.Nivel).Distinct().ToList();

            List<PreguntaDTO> preguntas= dsJuego.Preguntas.Where(drPreg => drPreg.Nivel == nivel).Select(drPreg => new PreguntaDTO { NumPregunta = drPreg.NumPregunta, Enunciado = drPreg.Enunciado, Nivel = drPreg.Nivel, ListaRespuestas = ListaRespuestas(drPreg)}).ToList();

            msj = "";
            return preguntas;
        }

        public List<RespuestaDTO> ListaRespuestas(DsJuego.PreguntasRow dr )
        {
            List<RespuestaDTO> listaRespuestas =dr.GetRespuestasRows().Select(drResp => new RespuestaDTO { NumPregunta = drResp.NumPregunta, NumRespuesta = drResp.NumRespuesta, PosibleRespuesta = drResp.PosibleRespuesta, Valida = drResp.Valida, Explicacion = dsJuego.RespNoValidas.ExplicacionColumn.ToString()}).ToList();

            return listaRespuestas;
        }
    }
}
