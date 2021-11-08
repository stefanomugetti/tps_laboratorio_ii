
namespace FormTPFinal
{
    partial class Frm_Liga
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
            this.dtvg_Equipos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Jdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_ListaJdr = new System.Windows.Forms.DataGridView();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Posicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linea2 = new System.Windows.Forms.TextBox();
            this.lbl_Mensaje2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NombreLiga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_Equipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaJdr)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvg_Equipos
            // 
            this.dtvg_Equipos.AllowUserToDeleteRows = false;
            this.dtvg_Equipos.AllowUserToResizeColumns = false;
            this.dtvg_Equipos.AllowUserToResizeRows = false;
            this.dtvg_Equipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvg_Equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvg_Equipos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtvg_Equipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvg_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvg_Equipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clm_Jdr});
            this.dtvg_Equipos.Location = new System.Drawing.Point(476, 138);
            this.dtvg_Equipos.Name = "dtvg_Equipos";
            this.dtvg_Equipos.ReadOnly = true;
            this.dtvg_Equipos.RowHeadersWidth = 4;
            this.dtvg_Equipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtvg_Equipos.RowTemplate.Height = 25;
            this.dtvg_Equipos.Size = new System.Drawing.Size(385, 316);
            this.dtvg_Equipos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "AÑO FUNDACION";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "VALOR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // clm_Jdr
            // 
            this.clm_Jdr.HeaderText = "JUGADORES";
            this.clm_Jdr.Name = "clm_Jdr";
            this.clm_Jdr.ReadOnly = true;
            // 
            // dtgv_ListaJdr
            // 
            this.dtgv_ListaJdr.AllowUserToDeleteRows = false;
            this.dtgv_ListaJdr.AllowUserToResizeColumns = false;
            this.dtgv_ListaJdr.AllowUserToResizeRows = false;
            this.dtgv_ListaJdr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListaJdr.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_ListaJdr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_ListaJdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_ListaJdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nombre,
            this.clm_Posicio,
            this.cl_Edad,
            this.cl_Equipo,
            this.clm_Precio});
            this.dtgv_ListaJdr.Location = new System.Drawing.Point(-4, 138);
            this.dtgv_ListaJdr.Name = "dtgv_ListaJdr";
            this.dtgv_ListaJdr.RowHeadersVisible = false;
            this.dtgv_ListaJdr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgv_ListaJdr.RowTemplate.Height = 25;
            this.dtgv_ListaJdr.Size = new System.Drawing.Size(447, 332);
            this.dtgv_ListaJdr.TabIndex = 3;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = " NOMBRE";
            this.clm_Nombre.Name = "clm_Nombre";
            // 
            // clm_Posicio
            // 
            this.clm_Posicio.HeaderText = "POSICION";
            this.clm_Posicio.Name = "clm_Posicio";
            // 
            // cl_Edad
            // 
            this.cl_Edad.HeaderText = "EDAD";
            this.cl_Edad.Name = "cl_Edad";
            // 
            // cl_Equipo
            // 
            this.cl_Equipo.HeaderText = "EQUIPO";
            this.cl_Equipo.Name = "cl_Equipo";
            // 
            // clm_Precio
            // 
            this.clm_Precio.HeaderText = "VALOR";
            this.clm_Precio.Name = "clm_Precio";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(438, 135);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(10, 315);
            this.textBox2.TabIndex = 8;
            // 
            // linea2
            // 
            this.linea2.BackColor = System.Drawing.Color.Black;
            this.linea2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linea2.Cursor = System.Windows.Forms.Cursors.Default;
            this.linea2.Enabled = false;
            this.linea2.Location = new System.Drawing.Point(-4, 135);
            this.linea2.Multiline = true;
            this.linea2.Name = "linea2";
            this.linea2.ReadOnly = true;
            this.linea2.Size = new System.Drawing.Size(865, 5);
            this.linea2.TabIndex = 9;
            // 
            // lbl_Mensaje2
            // 
            this.lbl_Mensaje2.AutoSize = true;
            this.lbl_Mensaje2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mensaje2.Location = new System.Drawing.Point(498, 111);
            this.lbl_Mensaje2.Name = "lbl_Mensaje2";
            this.lbl_Mensaje2.Size = new System.Drawing.Size(253, 21);
            this.lbl_Mensaje2.TabIndex = 10;
            this.lbl_Mensaje2.Text = "EQUIPOS MEJORES VALORADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADORES MEJORES VALORADOS";
            // 
            // lbl_NombreLiga
            // 
            this.lbl_NombreLiga.AutoSize = true;
            this.lbl_NombreLiga.Font = new System.Drawing.Font("Yu Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreLiga.Location = new System.Drawing.Point(39, 9);
            this.lbl_NombreLiga.Name = "lbl_NombreLiga";
            this.lbl_NombreLiga.Size = new System.Drawing.Size(140, 61);
            this.lbl_NombreLiga.TabIndex = 12;
            this.lbl_NombreLiga.Text = "label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(400, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 65);
            this.label3.TabIndex = 13;
            this.label3.Text = "%";
            // 
            // Frm_Liga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lbl_NombreLiga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Mensaje2);
            this.Controls.Add(this.linea2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtgv_ListaJdr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvg_Equipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Liga";
            this.Text = "LIGA ARGENTINA DE FUTBOL";
            ((System.ComponentModel.ISupportInitialize)(this.dtvg_Equipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaJdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtvg_Equipos;
        private System.Windows.Forms.DataGridView dtgv_ListaJdr;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox linea2;
        private System.Windows.Forms.Label lbl_Mensaje2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_NombreLiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Jdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Posicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio;
    }
}