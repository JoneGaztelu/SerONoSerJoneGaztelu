using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablero
{
    public partial class FrmNivel : Form
    {
        public FrmNivel()
        {
            InitializeComponent();
        }

        public string nivel;
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            /*if (string.IsNullOrWhiteSpace(txtNivel.Text))
            {
                MessageBox.Show("La elección del nivel no puede quedarse en blanco", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txtNivel.Text, out int nivel))
            {
                MessageBox.Show("Para la elección de un nivel el valor introducido debe ser un número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nivel =
            }*/
            //FrmJuego frmJ = new FrmJuego();
            nivel = txtNivel.Text;
            //frmJ.Show();

        }
    }
}
