
namespace FormTPFinal
{
    partial class Frm_AltaEquipo
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.txt_AñoCreacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(122, 198);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_Crear.TabIndex = 0;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(93, 42);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(141, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(93, 95);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.PlaceholderText = "Ingrese valor";
            this.txt_Valor.Size = new System.Drawing.Size(141, 23);
            this.txt_Valor.TabIndex = 2;
            // 
            // txt_AñoCreacion
            // 
            this.txt_AñoCreacion.Location = new System.Drawing.Point(93, 148);
            this.txt_AñoCreacion.Name = "txt_AñoCreacion";
            this.txt_AñoCreacion.PlaceholderText = "Ingrese año de creacion";
            this.txt_AñoCreacion.Size = new System.Drawing.Size(141, 23);
            this.txt_AñoCreacion.TabIndex = 3;
            // 
            // Frm_AltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 258);
            this.Controls.Add(this.txt_AñoCreacion);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Crear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.TextBox txt_AñoCreacion;
    }
}