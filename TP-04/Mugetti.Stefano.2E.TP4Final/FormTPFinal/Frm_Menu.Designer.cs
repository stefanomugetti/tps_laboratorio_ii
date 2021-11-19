
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
            this.lbl_menu = new System.Windows.Forms.Label();
            this.pnl_Opciones = new System.Windows.Forms.Panel();
            this.txt_linea = new System.Windows.Forms.TextBox();
            this.lbl_Copa = new System.Windows.Forms.Label();
            this.btn_Informes = new System.Windows.Forms.Button();
            this.btn_Liga = new System.Windows.Forms.Button();
            this.btn_Equipos = new System.Windows.Forms.Button();
            this.btn_Jugadores = new System.Windows.Forms.Button();
            this.pnl_Barra = new System.Windows.Forms.Panel();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.pnl_Formularios = new System.Windows.Forms.Panel();
            this.btn_Frenar = new System.Windows.Forms.Button();
            this.btn_Activar = new System.Windows.Forms.Button();
            this.pnl_Opciones.SuspendLayout();
            this.pnl_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_menu.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_menu.Location = new System.Drawing.Point(317, 2);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(163, 24);
            this.lbl_menu.TabIndex = 1;
            this.lbl_menu.Text = "MENU PRINCIPAL";
            // 
            // pnl_Opciones
            // 
            this.pnl_Opciones.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Opciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Opciones.Controls.Add(this.txt_linea);
            this.pnl_Opciones.Controls.Add(this.lbl_Copa);
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
            // txt_linea
            // 
            this.txt_linea.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_linea.Enabled = false;
            this.txt_linea.Location = new System.Drawing.Point(-2, 102);
            this.txt_linea.Multiline = true;
            this.txt_linea.Name = "txt_linea";
            this.txt_linea.Size = new System.Drawing.Size(159, 16);
            this.txt_linea.TabIndex = 8;
            // 
            // lbl_Copa
            // 
            this.lbl_Copa.AutoSize = true;
            this.lbl_Copa.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Copa.Location = new System.Drawing.Point(12, 9);
            this.lbl_Copa.Name = "lbl_Copa";
            this.lbl_Copa.Size = new System.Drawing.Size(138, 97);
            this.lbl_Copa.TabIndex = 0;
            this.lbl_Copa.Text = "%";
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
            this.btn_Liga.Image = global::FormTPFinal.Properties.Resources.entidades;
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
            // pnl_Barra
            // 
            this.pnl_Barra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Barra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Barra.Controls.Add(this.btn_Frenar);
            this.pnl_Barra.Controls.Add(this.btn_Activar);
            this.pnl_Barra.Controls.Add(this.lbl_Hora);
            this.pnl_Barra.Controls.Add(this.btn_Salir);
            this.pnl_Barra.Controls.Add(this.lbl_menu);
            this.pnl_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Barra.Location = new System.Drawing.Point(159, 0);
            this.pnl_Barra.Name = "pnl_Barra";
            this.pnl_Barra.Size = new System.Drawing.Size(829, 31);
            this.pnl_Barra.TabIndex = 3;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Hora.Location = new System.Drawing.Point(84, 4);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(41, 20);
            this.lbl_Hora.TabIndex = 6;
            this.lbl_Hora.Text = "hora";
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
            // btn_Frenar
            // 
            this.btn_Frenar.Location = new System.Drawing.Point(3, 3);
            this.btn_Frenar.Name = "btn_Frenar";
            this.btn_Frenar.Size = new System.Drawing.Size(75, 22);
            this.btn_Frenar.TabIndex = 0;
            this.btn_Frenar.Text = "Frenar->";
            this.btn_Frenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Frenar.UseVisualStyleBackColor = true;
            this.btn_Frenar.Click += new System.EventHandler(this.btn_Frenar_Click);
            // 
            // btn_Activar
            // 
            this.btn_Activar.Location = new System.Drawing.Point(3, 2);
            this.btn_Activar.Name = "btn_Activar";
            this.btn_Activar.Size = new System.Drawing.Size(75, 23);
            this.btn_Activar.TabIndex = 0;
            this.btn_Activar.Text = "Activar->";
            this.btn_Activar.UseVisualStyleBackColor = true;
            this.btn_Activar.Visible = false;
            this.btn_Activar.Click += new System.EventHandler(this.btn_Activar_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 461);
            this.Controls.Add(this.pnl_Formularios);
            this.Controls.Add(this.pnl_Barra);
            this.Controls.Add(this.pnl_Opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Opciones.ResumeLayout(false);
            this.pnl_Opciones.PerformLayout();
            this.pnl_Barra.ResumeLayout(false);
            this.pnl_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Panel pnl_Opciones;
        private System.Windows.Forms.Button btn_Jugadores;
        private System.Windows.Forms.Panel pnl_Barra;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Button btn_Liga;
        private System.Windows.Forms.Button btn_Equipos;
        private System.Windows.Forms.Panel pnl_Formularios;
        private System.Windows.Forms.Button btn_Informes;
        private System.Windows.Forms.Label lbl_Copa;
        private System.Windows.Forms.TextBox txt_linea;
        public System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Button btn_Frenar;
        private System.Windows.Forms.Button btn_Activar;
    }
}

