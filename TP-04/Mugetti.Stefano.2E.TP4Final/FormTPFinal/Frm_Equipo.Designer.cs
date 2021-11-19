
namespace FormTPFinal
{
    partial class Frm_Equipo
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
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.dtgv_Lista = new System.Windows.Forms.DataGridView();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Jugadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_RestaurarLista = new System.Windows.Forms.Button();
            this.btn_Elimina = new System.Windows.Forms.Button();
            this.lbl_Filtrar = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.cmb_FiltrarPor = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorValor = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorFundacion = new System.Windows.Forms.ComboBox();
            this.cmb_FiltrarPorCantJdr = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(548, 13);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(81, 23);
            this.btn_Crear.TabIndex = 0;
            this.btn_Crear.Text = "Crear Equipo";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(635, 13);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(81, 23);
            this.btn_Modificar.TabIndex = 37;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
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
            this.dtgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nombre,
            this.clm_Valor,
            this.clm_año,
            this.clm_Jugadores});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_Lista.Location = new System.Drawing.Point(9, 42);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.ShowCellToolTips = false;
            this.dtgv_Lista.ShowEditingIcon = false;
            this.dtgv_Lista.Size = new System.Drawing.Size(826, 407);
            this.dtgv_Lista.TabIndex = 36;
            this.dtgv_Lista.TabStop = false;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "NOMBRE";
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
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
            // clm_año
            // 
            this.clm_año.HeaderText = "AÑO CREACION";
            this.clm_año.Name = "clm_año";
            this.clm_año.ReadOnly = true;
            // 
            // clm_Jugadores
            // 
            this.clm_Jugadores.HeaderText = "CANTIDAD JUGADORES";
            this.clm_Jugadores.Name = "clm_Jugadores";
            this.clm_Jugadores.ReadOnly = true;
            // 
            // btn_RestaurarLista
            // 
            this.btn_RestaurarLista.Location = new System.Drawing.Point(745, 13);
            this.btn_RestaurarLista.Name = "btn_RestaurarLista";
            this.btn_RestaurarLista.Size = new System.Drawing.Size(81, 23);
            this.btn_RestaurarLista.TabIndex = 35;
            this.btn_RestaurarLista.Text = "Restaurar lista";
            this.btn_RestaurarLista.UseVisualStyleBackColor = true;
            this.btn_RestaurarLista.Click += new System.EventHandler(this.btn_RestaurarLista_Click);
            // 
            // btn_Elimina
            // 
            this.btn_Elimina.Location = new System.Drawing.Point(461, 13);
            this.btn_Elimina.Name = "btn_Elimina";
            this.btn_Elimina.Size = new System.Drawing.Size(81, 23);
            this.btn_Elimina.TabIndex = 38;
            this.btn_Elimina.Text = "Eliminar";
            this.btn_Elimina.UseVisualStyleBackColor = true;
            this.btn_Elimina.Click += new System.EventHandler(this.btn_Elimina_Click);
            // 
            // lbl_Filtrar
            // 
            this.lbl_Filtrar.AutoSize = true;
            this.lbl_Filtrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Filtrar.Location = new System.Drawing.Point(9, 17);
            this.lbl_Filtrar.Name = "lbl_Filtrar";
            this.lbl_Filtrar.Size = new System.Drawing.Size(56, 15);
            this.lbl_Filtrar.TabIndex = 44;
            this.lbl_Filtrar.Text = "FILTRAR:";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Max.Location = new System.Drawing.Point(198, 17);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(37, 15);
            this.lbl_Max.TabIndex = 43;
            this.lbl_Max.Text = "MAX:";
            this.lbl_Max.Visible = false;
            // 
            // cmb_FiltrarPor
            // 
            this.cmb_FiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPor.FormattingEnabled = true;
            this.cmb_FiltrarPor.Items.AddRange(new object[] {
            "Valor",
            "Año de fundacion",
            "Jugadores"});
            this.cmb_FiltrarPor.Location = new System.Drawing.Point(71, 13);
            this.cmb_FiltrarPor.Name = "cmb_FiltrarPor";
            this.cmb_FiltrarPor.Size = new System.Drawing.Size(121, 23);
            this.cmb_FiltrarPor.TabIndex = 42;
            this.cmb_FiltrarPor.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPor_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorValor
            // 
            this.cmb_FiltrarPorValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorValor.FormattingEnabled = true;
            this.cmb_FiltrarPorValor.Items.AddRange(new object[] {
            "10000000",
            "100000000",
            "250000000",
            "500000000",
            "1000000000",
            "2500000000",
            "5000000000",
            "10000000000"});
            this.cmb_FiltrarPorValor.Location = new System.Drawing.Point(232, 15);
            this.cmb_FiltrarPorValor.Name = "cmb_FiltrarPorValor";
            this.cmb_FiltrarPorValor.Size = new System.Drawing.Size(121, 23);
            this.cmb_FiltrarPorValor.TabIndex = 45;
            this.cmb_FiltrarPorValor.Visible = false;
            this.cmb_FiltrarPorValor.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorValor_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorFundacion
            // 
            this.cmb_FiltrarPorFundacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorFundacion.FormattingEnabled = true;
            this.cmb_FiltrarPorFundacion.Items.AddRange(new object[] {
            "1905",
            "1925",
            "1945",
            "1965",
            "1985",
            "2005",
            "2020"});
            this.cmb_FiltrarPorFundacion.Location = new System.Drawing.Point(232, 14);
            this.cmb_FiltrarPorFundacion.Name = "cmb_FiltrarPorFundacion";
            this.cmb_FiltrarPorFundacion.Size = new System.Drawing.Size(121, 23);
            this.cmb_FiltrarPorFundacion.TabIndex = 46;
            this.cmb_FiltrarPorFundacion.Visible = false;
            this.cmb_FiltrarPorFundacion.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorFundacion_SelectedIndexChanged);
            // 
            // cmb_FiltrarPorCantJdr
            // 
            this.cmb_FiltrarPorCantJdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarPorCantJdr.FormattingEnabled = true;
            this.cmb_FiltrarPorCantJdr.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmb_FiltrarPorCantJdr.Location = new System.Drawing.Point(232, 13);
            this.cmb_FiltrarPorCantJdr.Name = "cmb_FiltrarPorCantJdr";
            this.cmb_FiltrarPorCantJdr.Size = new System.Drawing.Size(121, 23);
            this.cmb_FiltrarPorCantJdr.TabIndex = 47;
            this.cmb_FiltrarPorCantJdr.Visible = false;
            this.cmb_FiltrarPorCantJdr.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarPorCantJdr_SelectedIndexChanged_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(374, 13);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(81, 23);
            this.btn_Guardar.TabIndex = 48;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Frm_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cmb_FiltrarPorCantJdr);
            this.Controls.Add(this.cmb_FiltrarPorFundacion);
            this.Controls.Add(this.cmb_FiltrarPorValor);
            this.Controls.Add(this.lbl_Filtrar);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.cmb_FiltrarPor);
            this.Controls.Add(this.btn_Elimina);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.dtgv_Lista);
            this.Controls.Add(this.btn_RestaurarLista);
            this.Controls.Add(this.btn_Crear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Equipo";
            this.Text = "Frm_Club";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.Button btn_RestaurarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_año;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Jugadores;
        private System.Windows.Forms.Button btn_Elimina;
        private System.Windows.Forms.Label lbl_Filtrar;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.ComboBox cmb_FiltrarPor;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorValor;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorFundacion;
        private System.Windows.Forms.ComboBox cmb_FiltrarPorCantJdr;
        private System.Windows.Forms.Button btn_Guardar;
    }
}