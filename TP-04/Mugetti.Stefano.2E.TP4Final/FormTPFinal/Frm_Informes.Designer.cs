
using System;

namespace FormTPFinal
{
    partial class Frm_Informes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Pie = new System.Windows.Forms.Button();
            this.lbl_Informes = new System.Windows.Forms.Label();
            this.lbl_Aviso = new System.Windows.Forms.Label();
            this.lbl_Jdrs = new System.Windows.Forms.Label();
            this.btn_Valor = new System.Windows.Forms.Button();
            this.btn_Edad = new System.Windows.Forms.Button();
            this.btn_Peso = new System.Windows.Forms.Button();
            this.btn_Altura = new System.Windows.Forms.Button();
            this.btn_Posicion = new System.Windows.Forms.Button();
            this.lbl_Equipo = new System.Windows.Forms.Label();
            this.btn_CantJdr = new System.Windows.Forms.Button();
            this.btn_AñoCreacion = new System.Windows.Forms.Button();
            this.btn_ValorEquipo = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Pie
            // 
            this.btn_Pie.Location = new System.Drawing.Point(70, 158);
            this.btn_Pie.Name = "btn_Pie";
            this.btn_Pie.Size = new System.Drawing.Size(91, 47);
            this.btn_Pie.TabIndex = 0;
            this.btn_Pie.Text = "Segun pie";
            this.btn_Pie.UseVisualStyleBackColor = true;
            this.btn_Pie.Click += new System.EventHandler(this.btn_Pie_Click);
            // 
            // lbl_Informes
            // 
            this.lbl_Informes.AutoSize = true;
            this.lbl_Informes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Informes.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Informes.Location = new System.Drawing.Point(239, -1);
            this.lbl_Informes.Name = "lbl_Informes";
            this.lbl_Informes.Size = new System.Drawing.Size(363, 86);
            this.lbl_Informes.TabIndex = 1;
            this.lbl_Informes.Text = "INFORMES";
            // 
            // lbl_Aviso
            // 
            this.lbl_Aviso.AutoSize = true;
            this.lbl_Aviso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Aviso.Location = new System.Drawing.Point(300, 70);
            this.lbl_Aviso.Name = "lbl_Aviso";
            this.lbl_Aviso.Size = new System.Drawing.Size(234, 15);
            this.lbl_Aviso.TabIndex = 2;
            this.lbl_Aviso.Text = "(Los informes se guardaran en el escritorio)";
            // 
            // lbl_Jdrs
            // 
            this.lbl_Jdrs.AutoSize = true;
            this.lbl_Jdrs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Jdrs.Location = new System.Drawing.Point(139, 129);
            this.lbl_Jdrs.Name = "lbl_Jdrs";
            this.lbl_Jdrs.Size = new System.Drawing.Size(77, 15);
            this.lbl_Jdrs.TabIndex = 3;
            this.lbl_Jdrs.Text = "JUGADORES";
            // 
            // btn_Valor
            // 
            this.btn_Valor.Location = new System.Drawing.Point(70, 360);
            this.btn_Valor.Name = "btn_Valor";
            this.btn_Valor.Size = new System.Drawing.Size(91, 47);
            this.btn_Valor.TabIndex = 4;
            this.btn_Valor.Text = "Segun valor";
            this.btn_Valor.UseVisualStyleBackColor = true;
            this.btn_Valor.Click += new System.EventHandler(this.Btn_Valor_Click);
            // 
            // btn_Edad
            // 
            this.btn_Edad.Location = new System.Drawing.Point(70, 257);
            this.btn_Edad.Name = "btn_Edad";
            this.btn_Edad.Size = new System.Drawing.Size(91, 46);
            this.btn_Edad.TabIndex = 5;
            this.btn_Edad.Text = "Segun edad";
            this.btn_Edad.UseVisualStyleBackColor = true;
            this.btn_Edad.Click += new System.EventHandler(this.Btn_Edad_Click);
            // 
            // btn_Peso
            // 
            this.btn_Peso.Location = new System.Drawing.Point(203, 157);
            this.btn_Peso.Name = "btn_Peso";
            this.btn_Peso.Size = new System.Drawing.Size(91, 46);
            this.btn_Peso.TabIndex = 6;
            this.btn_Peso.Text = "Segun Peso";
            this.btn_Peso.UseVisualStyleBackColor = true;
            this.btn_Peso.Click += new System.EventHandler(this.btn_Peso_Click);
            // 
            // btn_Altura
            // 
            this.btn_Altura.Location = new System.Drawing.Point(203, 257);
            this.btn_Altura.Name = "btn_Altura";
            this.btn_Altura.Size = new System.Drawing.Size(91, 46);
            this.btn_Altura.TabIndex = 7;
            this.btn_Altura.Text = "Segun Altura";
            this.btn_Altura.UseVisualStyleBackColor = true;
            this.btn_Altura.Click += new System.EventHandler(this.Btn_Altura_Click);
            // 
            // btn_Posicion
            // 
            this.btn_Posicion.Location = new System.Drawing.Point(203, 360);
            this.btn_Posicion.Name = "btn_Posicion";
            this.btn_Posicion.Size = new System.Drawing.Size(91, 47);
            this.btn_Posicion.TabIndex = 8;
            this.btn_Posicion.Text = "Segun posicion";
            this.btn_Posicion.UseVisualStyleBackColor = true;
            this.btn_Posicion.Click += new System.EventHandler(this.Btn_Posicion_Click);
            // 
            // lbl_Equipo
            // 
            this.lbl_Equipo.AutoSize = true;
            this.lbl_Equipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Equipo.Location = new System.Drawing.Point(585, 129);
            this.lbl_Equipo.Name = "lbl_Equipo";
            this.lbl_Equipo.Size = new System.Drawing.Size(58, 15);
            this.lbl_Equipo.TabIndex = 9;
            this.lbl_Equipo.Text = "EQUIPOS";
            // 
            // btn_CantJdr
            // 
            this.btn_CantJdr.Location = new System.Drawing.Point(658, 208);
            this.btn_CantJdr.Name = "btn_CantJdr";
            this.btn_CantJdr.Size = new System.Drawing.Size(91, 47);
            this.btn_CantJdr.TabIndex = 12;
            this.btn_CantJdr.Text = "Segun Cant Jugadores";
            this.btn_CantJdr.UseVisualStyleBackColor = true;
            this.btn_CantJdr.Click += new System.EventHandler(this.Btn_CantJdr_Click);
            // 
            // btn_AñoCreacion
            // 
            this.btn_AñoCreacion.Location = new System.Drawing.Point(566, 302);
            this.btn_AñoCreacion.Name = "btn_AñoCreacion";
            this.btn_AñoCreacion.Size = new System.Drawing.Size(91, 53);
            this.btn_AñoCreacion.TabIndex = 11;
            this.btn_AñoCreacion.Text = "Segun año de fundacion";
            this.btn_AñoCreacion.UseVisualStyleBackColor = true;
            this.btn_AñoCreacion.Click += new System.EventHandler(this.Btn_AñoCreacion_Click);
            // 
            // btn_ValorEquipo
            // 
            this.btn_ValorEquipo.Location = new System.Drawing.Point(496, 209);
            this.btn_ValorEquipo.Name = "btn_ValorEquipo";
            this.btn_ValorEquipo.Size = new System.Drawing.Size(91, 46);
            this.btn_ValorEquipo.TabIndex = 10;
            this.btn_ValorEquipo.Text = "Segun Valor";
            this.btn_ValorEquipo.UseVisualStyleBackColor = true;
            this.btn_ValorEquipo.Click += new System.EventHandler(this.Btn_ValorEquipo_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(800, 93);
            this.pnl_Titulo.TabIndex = 14;
            // 
            // Frm_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CantJdr);
            this.Controls.Add(this.btn_AñoCreacion);
            this.Controls.Add(this.btn_ValorEquipo);
            this.Controls.Add(this.lbl_Equipo);
            this.Controls.Add(this.btn_Posicion);
            this.Controls.Add(this.btn_Altura);
            this.Controls.Add(this.btn_Peso);
            this.Controls.Add(this.btn_Edad);
            this.Controls.Add(this.btn_Valor);
            this.Controls.Add(this.lbl_Jdrs);
            this.Controls.Add(this.lbl_Aviso);
            this.Controls.Add(this.lbl_Informes);
            this.Controls.Add(this.btn_Pie);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Informes";
            this.Text = "Frm_Informes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pie;
        private System.Windows.Forms.Label lbl_Informes;
        private System.Windows.Forms.Label lbl_Aviso;
        private System.Windows.Forms.Label lbl_Jdrs;
        private System.Windows.Forms.Button btn_Valor;
        private System.Windows.Forms.Button btn_Edad;
        private System.Windows.Forms.Button btn_Peso;
        private System.Windows.Forms.Button btn_Altura;
        private System.Windows.Forms.Button btn_Posicion;
        private System.Windows.Forms.Label lbl_Equipo;
        private System.Windows.Forms.Button btn_CantJdr;
        private System.Windows.Forms.Button btn_AñoCreacion;
        private System.Windows.Forms.Button btn_ValorEquipo;
        private System.Windows.Forms.Panel pnl_Titulo;
        //private EventHandler btn_Valor_Click;
        //private EventHandler btn_Edad_Click;
        //private EventHandler btn_Altura_Click;
        //private EventHandler btn_Posicion_Click;
        //private EventHandler btn_CantJdr_Click;
        //private EventHandler btn_AñoCreacion_Click;
        //private EventHandler btn_ValorEquipo_Click;
    }
}