
namespace FormTPFinal
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Opciones = new System.Windows.Forms.Panel();
            this.linea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Informes = new System.Windows.Forms.Button();
            this.btn_Liga = new System.Windows.Forms.Button();
            this.btn_Equipos = new System.Windows.Forms.Button();
            this.btn_Jugadores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.pnl_Formularios = new System.Windows.Forms.Panel();
            this.pnl_Opciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(317, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // pnl_Opciones
            // 
            this.pnl_Opciones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Opciones.Controls.Add(this.linea);
            this.pnl_Opciones.Controls.Add(this.label2);
            this.pnl_Opciones.Controls.Add(this.btn_Informes);
            this.pnl_Opciones.Controls.Add(this.btn_Liga);
            this.pnl_Opciones.Controls.Add(this.btn_Equipos);
            this.pnl_Opciones.Controls.Add(this.btn_Jugadores);
            this.pnl_Opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Opciones.Location = new System.Drawing.Point(0, 0);
            this.pnl_Opciones.Name = "pnl_Opciones";
            this.pnl_Opciones.Size = new System.Drawing.Size(159, 461);
            this.pnl_Opciones.TabIndex = 2;
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.SystemColors.MenuText;
            this.linea.Enabled = false;
            this.linea.Location = new System.Drawing.Point(-2, 102);
            this.linea.Multiline = true;
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(159, 16);
            this.linea.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 97);
            this.label2.TabIndex = 0;
            this.label2.Text = "%";
            // 
            // btn_Informes
            // 
            this.btn_Informes.BackColor = System.Drawing.Color.Black;
            this.btn_Informes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Informes.FlatAppearance.BorderSize = 0;
            this.btn_Informes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informes.ForeColor = System.Drawing.Color.White;
            this.btn_Informes.Image = global::FormTPFinal.Properties.Resources.Productos_Gris;
            this.btn_Informes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Informes.Location = new System.Drawing.Point(-2, 387);
            this.btn_Informes.Name = "btn_Informes";
            this.btn_Informes.Size = new System.Drawing.Size(144, 41);
            this.btn_Informes.TabIndex = 7;
            this.btn_Informes.Text = "       Informes";
            this.btn_Informes.UseVisualStyleBackColor = false;
            this.btn_Informes.Click += new System.EventHandler(this.btn_Informes_Click);
            // 
            // btn_Liga
            // 
            this.btn_Liga.BackColor = System.Drawing.Color.Black;
            this.btn_Liga.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Liga.FlatAppearance.BorderSize = 0;
            this.btn_Liga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Liga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Liga.ForeColor = System.Drawing.Color.White;
            this.btn_Liga.Image = ((System.Drawing.Image)(resources.GetObject("btn_Liga.Image")));
            this.btn_Liga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Liga.Location = new System.Drawing.Point(-2, 153);
            this.btn_Liga.Name = "btn_Liga";
            this.btn_Liga.Size = new System.Drawing.Size(144, 41);
            this.btn_Liga.TabIndex = 6;
            this.btn_Liga.Text = "        Liga";
            this.btn_Liga.UseVisualStyleBackColor = false;
            this.btn_Liga.Click += new System.EventHandler(this.btn_Liga_Click);
            // 
            // btn_Equipos
            // 
            this.btn_Equipos.BackColor = System.Drawing.Color.Black;
            this.btn_Equipos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Equipos.FlatAppearance.BorderSize = 0;
            this.btn_Equipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Equipos.ForeColor = System.Drawing.Color.White;
            this.btn_Equipos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Equipos.Image")));
            this.btn_Equipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Equipos.Location = new System.Drawing.Point(-2, 229);
            this.btn_Equipos.Name = "btn_Equipos";
            this.btn_Equipos.Size = new System.Drawing.Size(144, 41);
            this.btn_Equipos.TabIndex = 5;
            this.btn_Equipos.Text = "       Equipos";
            this.btn_Equipos.UseVisualStyleBackColor = false;
            this.btn_Equipos.Click += new System.EventHandler(this.btn_Equipos_Click);
            // 
            // btn_Jugadores
            // 
            this.btn_Jugadores.BackColor = System.Drawing.Color.Black;
            this.btn_Jugadores.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_Jugadores.FlatAppearance.BorderSize = 0;
            this.btn_Jugadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btn_Jugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Jugadores.ForeColor = System.Drawing.Color.White;
            this.btn_Jugadores.Image = ((System.Drawing.Image)(resources.GetObject("btn_Jugadores.Image")));
            this.btn_Jugadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Jugadores.Location = new System.Drawing.Point(-2, 308);
            this.btn_Jugadores.Name = "btn_Jugadores";
            this.btn_Jugadores.Size = new System.Drawing.Size(144, 41);
            this.btn_Jugadores.TabIndex = 4;
            this.btn_Jugadores.Text = "        Jugadores";
            this.btn_Jugadores.UseVisualStyleBackColor = false;
            this.btn_Jugadores.Click += new System.EventHandler(this.btn_Jugadores_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(159, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 31);
            this.panel1.TabIndex = 3;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(797, -2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(25, 26);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pnl_Formularios
            // 
            this.pnl_Formularios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_Formularios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Formularios.Location = new System.Drawing.Point(159, 31);
            this.pnl_Formularios.Name = "pnl_Formularios";
            this.pnl_Formularios.Size = new System.Drawing.Size(829, 430);
            this.pnl_Formularios.TabIndex = 4;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 461);
            this.Controls.Add(this.pnl_Formularios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Opciones.ResumeLayout(false);
            this.pnl_Opciones.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Opciones;
        private System.Windows.Forms.Button btn_Jugadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Button btn_Liga;
        private System.Windows.Forms.Button btn_Equipos;
        private System.Windows.Forms.Panel pnl_Formularios;
        private System.Windows.Forms.Button btn_Informes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox linea;
    }
}

