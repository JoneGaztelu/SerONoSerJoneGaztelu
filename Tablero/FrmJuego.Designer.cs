﻿namespace Tablero
{
    partial class FrmJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRespuestaValida = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tmrTiempoTotal = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRespuestaValida
            // 
            this.lblRespuestaValida.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblRespuestaValida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRespuestaValida.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaValida.Location = new System.Drawing.Point(84, 644);
            this.lblRespuestaValida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaValida.Name = "lblRespuestaValida";
            this.lblRespuestaValida.Size = new System.Drawing.Size(1060, 68);
            this.lblRespuestaValida.TabIndex = 29;
            this.lblRespuestaValida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblEnunciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEnunciado.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(83, 14);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(1060, 68);
            this.lblEnunciado.TabIndex = 28;
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(895, 463);
            this.btn12.Margin = new System.Windows.Forms.Padding(4);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(249, 146);
            this.btn12.TabIndex = 27;
            this.btn12.Tag = "SacarRespuestas";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(624, 463);
            this.btn11.Margin = new System.Windows.Forms.Padding(4);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(249, 146);
            this.btn11.TabIndex = 26;
            this.btn11.Tag = "SacarRespuestas";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(352, 463);
            this.btn10.Margin = new System.Windows.Forms.Padding(4);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(249, 146);
            this.btn10.TabIndex = 25;
            this.btn10.Tag = "SacarRespuestas";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(79, 463);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(249, 146);
            this.btn9.TabIndex = 24;
            this.btn9.Tag = "SacarRespuestas";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(895, 290);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(249, 146);
            this.btn8.TabIndex = 23;
            this.btn8.Tag = "SacarRespuestas";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(624, 290);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(249, 146);
            this.btn7.TabIndex = 22;
            this.btn7.Tag = "SacarRespuestas";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(352, 290);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(249, 146);
            this.btn6.TabIndex = 21;
            this.btn6.Tag = "SacarRespuestas";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(79, 290);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(249, 146);
            this.btn5.TabIndex = 20;
            this.btn5.Tag = "SacarRespuestas";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(895, 122);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(249, 146);
            this.btn4.TabIndex = 19;
            this.btn4.Tag = "SacarRespuestas";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(624, 122);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(249, 146);
            this.btn3.TabIndex = 18;
            this.btn3.Tag = "SacarRespuestas";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(352, 122);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(249, 146);
            this.btn2.TabIndex = 17;
            this.btn2.Tag = "SacarRespuestas";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(79, 122);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(249, 146);
            this.btn1.TabIndex = 16;
            this.btn1.Tag = "SacarRespuestas";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackgroundImage = global::Tablero.Properties.Resources.reset;
            this.btnComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnComenzar.Location = new System.Drawing.Point(1201, 327);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(147, 78);
            this.btnComenzar.TabIndex = 32;
            this.btnComenzar.Text = "Re/&Comenzar";
            this.btnComenzar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackgroundImage = global::Tablero.Properties.Resources.exit;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinalizar.Location = new System.Drawing.Point(1201, 220);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(147, 75);
            this.btnFinalizar.TabIndex = 31;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // tmrTiempoTotal
            // 
            this.tmrTiempoTotal.Interval = 1000;
            this.tmrTiempoTotal.Tick += new System.EventHandler(this.tmrTiempoTotal_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTiempo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(1238, 499);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(79, 68);
            this.lblTiempo.TabIndex = 33;
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            this.lblNivel.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNivel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(1249, 60);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(79, 68);
            this.lblNivel.TabIndex = 34;
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1264, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1217, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tiempo restante";
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 724);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblRespuestaValida);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFinalizar;
        internal System.Windows.Forms.Label lblRespuestaValida;
        internal System.Windows.Forms.Label lblEnunciado;
        internal System.Windows.Forms.Button btn12;
        internal System.Windows.Forms.Button btn11;
        internal System.Windows.Forms.Button btn10;
        internal System.Windows.Forms.Button btn9;
        internal System.Windows.Forms.Button btn8;
        internal System.Windows.Forms.Button btn7;
        internal System.Windows.Forms.Button btn6;
        internal System.Windows.Forms.Button btn5;
        internal System.Windows.Forms.Button btn4;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button btn2;
        internal System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Timer tmrTiempoTotal;
        internal System.Windows.Forms.Label lblTiempo;
        internal System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

