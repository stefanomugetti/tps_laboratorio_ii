
namespace FormTPFinal
{
    partial class Frm_AltaJugador
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
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.nud_Edad = new System.Windows.Forms.NumericUpDown();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Nacionalidad = new System.Windows.Forms.TextBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Equipo = new System.Windows.Forms.TextBox();
            this.cmb_Posicion = new System.Windows.Forms.ComboBox();
            this.cmb_PieHabil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(128, 187);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.PlaceholderText = "Ingrese valor";
            this.txt_Valor.Size = new System.Drawing.Size(141, 23);
            this.txt_Valor.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(128, 25);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(141, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(128, 54);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Ingrese apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(141, 23);
            this.txt_Apellido.TabIndex = 1;
            // 
            // nud_Edad
            // 
            this.nud_Edad.Location = new System.Drawing.Point(202, 104);
            this.nud_Edad.Name = "nud_Edad";
            this.nud_Edad.Size = new System.Drawing.Size(53, 23);
            this.nud_Edad.TabIndex = 3;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Edad.Location = new System.Drawing.Point(154, 109);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(42, 15);
            this.lbl_Edad.TabIndex = 7;
            this.lbl_Edad.Text = "EDAD:";
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(128, 129);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.PlaceholderText = "Ingrese peso (ej 70.5)";
            this.txt_Peso.Size = new System.Drawing.Size(141, 23);
            this.txt_Peso.TabIndex = 4;
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(128, 245);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.PlaceholderText = "Ingrese altura (ej 1.80)";
            this.txt_Altura.Size = new System.Drawing.Size(141, 23);
            this.txt_Altura.TabIndex = 8;
            // 
            // txt_Nacionalidad
            // 
            this.txt_Nacionalidad.Location = new System.Drawing.Point(128, 274);
            this.txt_Nacionalidad.Name = "txt_Nacionalidad";
            this.txt_Nacionalidad.PlaceholderText = "Ingrese nacionalidad";
            this.txt_Nacionalidad.Size = new System.Drawing.Size(141, 23);
            this.txt_Nacionalidad.TabIndex = 9;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(156, 328);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_Crear.TabIndex = 11;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(128, 83);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "Ingrese DNI";
            this.txt_Dni.Size = new System.Drawing.Size(141, 23);
            this.txt_Dni.TabIndex = 2;
            // 
            // txt_Equipo
            // 
            this.txt_Equipo.Location = new System.Drawing.Point(128, 303);
            this.txt_Equipo.Name = "txt_Equipo";
            this.txt_Equipo.PlaceholderText = "Ingrese nombre de equipo";
            this.txt_Equipo.Size = new System.Drawing.Size(141, 23);
            this.txt_Equipo.TabIndex = 10;
            // 
            // cmb_Posicion
            // 
            this.cmb_Posicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Posicion.FormattingEnabled = true;
            this.cmb_Posicion.Items.AddRange(new object[] {
            "Arquero",
            "Defensa",
            "Mediocampista",
            "Delantero"});
            this.cmb_Posicion.Location = new System.Drawing.Point(128, 158);
            this.cmb_Posicion.Name = "cmb_Posicion";
            this.cmb_Posicion.Size = new System.Drawing.Size(141, 23);
            this.cmb_Posicion.TabIndex = 5;
            // 
            // cmb_PieHabil
            // 
            this.cmb_PieHabil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PieHabil.FormattingEnabled = true;
            this.cmb_PieHabil.Items.AddRange(new object[] {
            "Izquierdo",
            "Derecho"});
            this.cmb_PieHabil.Location = new System.Drawing.Point(128, 216);
            this.cmb_PieHabil.Name = "cmb_PieHabil";
            this.cmb_PieHabil.Size = new System.Drawing.Size(141, 23);
            this.cmb_PieHabil.TabIndex = 7;
            // 
            // Frm_AltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 363);
            this.Controls.Add(this.cmb_PieHabil);
            this.Controls.Add(this.cmb_Posicion);
            this.Controls.Add(this.txt_Equipo);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.txt_Nacionalidad);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.nud_Edad);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_Nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltaJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Jugador";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.NumericUpDown nud_Edad;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Nacionalidad;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Equipo;
        private System.Windows.Forms.ComboBox cmb_Posicion;
        private System.Windows.Forms.ComboBox cmb_PieHabil;
    }
}