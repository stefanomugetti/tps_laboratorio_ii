
namespace FormTPFinal
{
    partial class Frm_Jugadores
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
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.cmb_FiltrarPor = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorPie = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorPeso = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorAltura = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorValor = new System.Windows.Forms.ComboBox();
            this.dtgv_Lista = new System.Windows.Forms.DataGridView();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Pie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_FiltrarPorEdad = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cmb_Equipos = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorNacionalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(462, 13);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta.TabIndex = 0;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Location = new System.Drawing.Point(733, 13);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(92, 23);
            this.btn_Restaurar.TabIndex = 1;
            this.btn_Restaurar.Text = "Restaurar Lista";
            this.btn_Restaurar.UseVisualStyleBackColor = true;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // cmb_FiltrarPor
            // 
            this.cmb_FiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPor.FormattingEnabled = true;
            this.cmb_FiltrarPor.Items.AddRange(new object[] {
            "Edad",
            "Peso",
            "Altura",
            "Valor",
            "Pie habil",
            "Equipo",
            "Nacionalidad"});
            this.cmb_FiltrarPor.Location = new System.Drawing.Point(70, 12);
            this.cmb_FiltrarPor.Name = "cmb_FiltrarPor";
            this.cmb_FiltrarPor.Size = new System.Drawing.Size(121, 23);
            this.cmb_FiltrarPor.TabIndex = 2;
            this.cmb_FiltrarPor.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPor_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorPie
            // 
            this.cmb_FiltrarPorPie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorPie.FormattingEnabled = true;
            this.cmb_FiltrarPorPie.Items.AddRange(new object[] {
            "Izquierdo",
            "Derecho"});
            this.cmb_FiltrarPorPie.Location = new System.Drawing.Point(240, 12);
            this.cmb_FiltrarPorPie.Name = "cmb_FiltrarPorPie";
            this.cmb_FiltrarPorPie.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorPie.TabIndex = 3;
            this.cmb_FiltrarPorPie.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorPie_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorPeso
            // 
            this.cmb_FiltrarPorPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorPeso.FormattingEnabled = true;
            this.cmb_FiltrarPorPeso.Items.AddRange(new object[] {
            "55",
            "65",
            "75",
            "85",
            "95"});
            this.cmb_FiltrarPorPeso.Location = new System.Drawing.Point(240, 13);
            this.cmb_FiltrarPorPeso.Name = "cmb_FiltrarPorPeso";
            this.cmb_FiltrarPorPeso.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorPeso.TabIndex = 4;
            this.cmb_FiltrarPorPeso.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorPeso_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorAltura
            // 
            this.cmb_FiltrarPorAltura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorAltura.FormattingEnabled = true;
            this.cmb_FiltrarPorAltura.Items.AddRange(new object[] {
            "1,50",
            "1,60",
            "1,70",
            "1,80",
            "1,90",
            "2,00"});
            this.cmb_FiltrarPorAltura.Location = new System.Drawing.Point(240, 13);
            this.cmb_FiltrarPorAltura.Name = "cmb_FiltrarPorAltura";
            this.cmb_FiltrarPorAltura.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorAltura.TabIndex = 5;
            this.cmb_FiltrarPorAltura.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorAltura_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorValor
            // 
            this.cmb_FiltrarPorValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorValor.FormattingEnabled = true;
            this.cmb_FiltrarPorValor.Items.AddRange(new object[] {
            "2500000",
            "10000000",
            "25000000",
            "50000000",
            "100000000",
            "250000000"});
            this.cmb_FiltrarPorValor.Location = new System.Drawing.Point(240, 13);
            this.cmb_FiltrarPorValor.Name = "cmb_FiltrarPorValor";
            this.cmb_FiltrarPorValor.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorValor.TabIndex = 6;
            this.cmb_FiltrarPorValor.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorValor_SelectedIndexChanged);
            // 
            // dtgv_Lista
            // 
            this.dtgv_Lista.AllowUserToAddRows = false;
            this.dtgv_Lista.AllowUserToDeleteRows = false;
            this.dtgv_Lista.AllowUserToOrderColumns = true;
            this.dtgv_Lista.AllowUserToResizeColumns = false;
            this.dtgv_Lista.AllowUserToResizeRows = false;
            this.dtgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Lista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nombre,
            this.clm_Apellido,
            this.clm_Edad,
            this.clm_Dni,
            this.clm_Pie,
            this.clm_Peso,
            this.clm_Altura,
            this.clm_Club,
            this.clm_Valor,
            this.clm_Nacionalidad});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.Window;
            this.dtgv_Lista.Location = new System.Drawing.Point(-1, 41);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.Size = new System.Drawing.Size(826, 397);
            this.dtgv_Lista.TabIndex = 37;
            this.dtgv_Lista.TabStop = false;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "NOMBRE";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_Apellido
            // 
            this.clm_Apellido.HeaderText = "APELLIDO";
            this.clm_Apellido.Name = "clm_Apellido";
            this.clm_Apellido.ReadOnly = true;
            // 
            // clm_Edad
            // 
            this.clm_Edad.HeaderText = "EDAD";
            this.clm_Edad.Name = "clm_Edad";
            this.clm_Edad.ReadOnly = true;
            // 
            // clm_Dni
            // 
            this.clm_Dni.HeaderText = "DNI";
            this.clm_Dni.Name = "clm_Dni";
            this.clm_Dni.ReadOnly = true;
            // 
            // clm_Pie
            // 
            this.clm_Pie.HeaderText = "PIE HABIL";
            this.clm_Pie.Name = "clm_Pie";
            this.clm_Pie.ReadOnly = true;
            // 
            // clm_Peso
            // 
            this.clm_Peso.HeaderText = "PESO";
            this.clm_Peso.Name = "clm_Peso";
            this.clm_Peso.ReadOnly = true;
            // 
            // clm_Altura
            // 
            this.clm_Altura.HeaderText = "ALTURA";
            this.clm_Altura.Name = "clm_Altura";
            this.clm_Altura.ReadOnly = true;
            // 
            // clm_Club
            // 
            this.clm_Club.HeaderText = "CLUB";
            this.clm_Club.Name = "clm_Club";
            this.clm_Club.ReadOnly = true;
            // 
            // clm_Valor
            // 
            this.clm_Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_Valor.FillWeight = 150F;
            this.clm_Valor.HeaderText = "VALOR";
            this.clm_Valor.MinimumWidth = 100;
            this.clm_Valor.Name = "clm_Valor";
            this.clm_Valor.ReadOnly = true;
            // 
            // clm_Nacionalidad
            // 
            this.clm_Nacionalidad.HeaderText = "PAIS";
            this.clm_Nacionalidad.Name = "clm_Nacionalidad";
            this.clm_Nacionalidad.ReadOnly = true;
            // 
            // cmb_FiltrarPorEdad
            // 
            this.cmb_FiltrarPorEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorEdad.FormattingEnabled = true;
            this.cmb_FiltrarPorEdad.Items.AddRange(new object[] {
            "16",
            "18",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cmb_FiltrarPorEdad.Location = new System.Drawing.Point(240, 12);
            this.cmb_FiltrarPorEdad.Name = "cmb_FiltrarPorEdad";
            this.cmb_FiltrarPorEdad.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorEdad.TabIndex = 38;
            this.cmb_FiltrarPorEdad.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorEdad_SelectedIndexChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(386, 13);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(58, 23);
            this.btn_Guardar.TabIndex = 39;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Max.Location = new System.Drawing.Point(197, 16);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(37, 15);
            this.lbl_Max.TabIndex = 40;
            this.lbl_Max.Text = "MAX:";
            this.lbl_Max.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "FILTRAR:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(624, 13);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 42;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(543, 13);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 43;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cmb_Equipos
            // 
            this.cmb_Equipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Equipos.FormattingEnabled = true;
            this.cmb_Equipos.Location = new System.Drawing.Point(240, 13);
            this.cmb_Equipos.Name = "cmb_Equipos";
            this.cmb_Equipos.Size = new System.Drawing.Size(130, 23);
            this.cmb_Equipos.TabIndex = 44;
            this.cmb_Equipos.Visible = false;
            this.cmb_Equipos.SelectedIndexChanged += new System.EventHandler(this.cmb_Equipos_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorNacionalidad
            // 
            this.cmb_FiltrarPorNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorNacionalidad.FormattingEnabled = true;
            this.cmb_FiltrarPorNacionalidad.Location = new System.Drawing.Point(240, 13);
            this.cmb_FiltrarPorNacionalidad.Name = "cmb_FiltrarPorNacionalidad";
            this.cmb_FiltrarPorNacionalidad.Size = new System.Drawing.Size(130, 23);
            this.cmb_FiltrarPorNacionalidad.TabIndex = 45;
            this.cmb_FiltrarPorNacionalidad.Visible = false;
            this.cmb_FiltrarPorNacionalidad.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorNacionalidad_SelectedIndexChanged);
            // 
            // Frm_Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.cmb_FiltrarPorNacionalidad);
            this.Controls.Add(this.cmb_Equipos);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cmb_FiltrarPorEdad);
            this.Controls.Add(this.dtgv_Lista);
            this.Controls.Add(this.cmb_FiltrarPorValor);
            this.Controls.Add(this.cmb_FiltrarPorAltura);
            this.Controls.Add(this.cmb_FiltrarPorPeso);
            this.Controls.Add(this.cmb_FiltrarPorPie);
            this.Controls.Add(this.cmb_FiltrarPor);
            this.Controls.Add(this.btn_Restaurar);
            this.Controls.Add(this.btn_Alta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Jugadores";
            this.Text = "Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.ComboBox cmb_FiltrarPor;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorPie;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorPeso;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorAltura;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorValor;
        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Pie;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nacionalidad;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorEdad;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ComboBox cmb_Equipos;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorNacionalidad;
    }
}