using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;
using System.Diagnostics;

namespace Tablero
{
    
    public partial class FrmJuego : Form
    {
        CapaJuego gstCN = new CapaJuego();
        FrmNivel frmN = new FrmNivel();
        //FrmJuego frmJ = new FrmJuego();
        PreguntaDTO preg;
        int cont = 60;
        //Stopwatch crono = new Stopwatch();
        public FrmJuego()
        {
            InitializeComponent();
            
            frmN.Show();
            //frmJ.Hide();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            lblNivel.Text = frmN.nivel;
            preg = gstCN.DevolverPregunta(int.Parse(lblNivel.Text));

            lblEnunciado.Text = preg.Enunciado;
            SacarResp();
            frmN.Hide();
            //crono.Start();
            cont = 60;
            tmrTiempoTotal.Enabled = true;
            

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            BotonClick(sender);
        }

        private void SacarResp()
        {
            int cont = 0;
            foreach (Button resp in this.Controls.OfType<Button>())
            {

                if (resp.Tag == "SacarRespuestas")
                {
                    resp.BackColor = Color.Gainsboro;
                    //crono.Restart();
                    resp.Text = preg.ListaRespuestas[cont].PosibleRespuesta;
                    cont += 1;
                }
            }

        }

        int contA = 0;
        int contF = 0;
        private void BotonClick(object sender)
        {
            RespuestaDTO respues = new RespuestaDTO();
            Button btn = (Button) sender;

            respues = preg.ListaRespuestas.Where(res => res.PosibleRespuesta.Equals(btn.Text)).Select(sRes => new RespuestaDTO (sRes.PosibleRespuesta, sRes.Explicacion, sRes.Valida)).SingleOrDefault();

            if (respues.Valida == true)
            {
                btn.BackColor = Color.Green;
                contA += 1;                
            }
            else
            {
                btn.BackColor = Color.Red;
                contF += 1;
                lblRespuestaValida.Text = respues.Explicacion;
            }

            if (contA == 8)
            {
                DialogResult dgMGBA = MessageBox.Show("Has acertado las 8 respuestas válidas, ¿deseas continuar con otra pregunta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMGBA == DialogResult.Yes)
                {
                    contA = 0;
                    contF = 0;
                    cont = 0;
                    frmN.Show();
                }
                else
                {
                    Close();
                }
            }
            else if (contF == 4)
            {
                DialogResult dgMGBF = MessageBox.Show("Has fallado las 4 respuestas erróneas, ¿deseas continuar con otra pregunta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMGBF == DialogResult.Yes)
                {
                    contA = 0;
                    contF = 0;
                    cont = 0;
                    frmN.Show();
                }
                else
                {
                    Close();
                }
            }
        }

       
        private void tmrTiempoTotal_Tick(object sender, EventArgs e)
        {
            //TimeSpan ts = new TimeSpan(0, 0, 0, 0,(int)crono.ElapsedMilliseconds);
            lblTiempo.Text = cont.ToString();//ts.Seconds.ToString();
            cont -= 1;

            if (cont == 0 )//ts.Seconds.ToString() == "59")
            {
                //crono.Stop();
                lblTiempo.Text = "0";
                DialogResult dgMGB= MessageBox.Show("Te has quedado sin tiempo para esta pregunta,¿deseas continuar con otra pregunta? No finalizará el programa", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (dgMGB == DialogResult.Yes)
                {
                    cont = 0;
                    frmN.Show();
                }
                else
                {
                    frmN.Show();
                    //this.Hide();
                }

                tmrTiempoTotal.Enabled = false;
            }
        }
    }
}