
namespace FormTPFinal
{
    partial class Frm_Informe
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.pnl_Barra = new System.Windows.Forms.Panel();
            this.lbl_Informes = new System.Windows.Forms.Label();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.pnl_Barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(12, 12);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Info.Location = new System.Drawing.Point(15, 54);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(72, 30);
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "label1";
            // 
            // pnl_Barra
            // 
            this.pnl_Barra.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_Barra.Controls.Add(this.lbl_Msg);
            this.pnl_Barra.Controls.Add(this.lbl_Informes);
            this.pnl_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Barra.Location = new System.Drawing.Point(0, 0);
            this.pnl_Barra.Name = "pnl_Barra";
            this.pnl_Barra.Size = new System.Drawing.Size(614, 51);
            this.pnl_Barra.TabIndex = 2;
            // 
            // lbl_Informes
            // 
            this.lbl_Informes.AutoSize = true;
            this.lbl_Informes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Informes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Informes.Location = new System.Drawing.Point(206, 0);
            this.lbl_Informes.Name = "lbl_Informes";
            this.lbl_Informes.Size = new System.Drawing.Size(200, 47);
            this.lbl_Informes.TabIndex = 3;
            this.lbl_Informes.Text = "INFORMES";
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(459, 0);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(155, 15);
            this.lbl_Msg.TabIndex = 3;
            this.lbl_Msg.Text = "GUARDADO EN ESCRITORIO";
            // 
            // Frm_Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 395);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.pnl_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 88);
            this.Name = "Frm_Informe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Informe";
            this.pnl_Barra.ResumeLayout(false);
            this.pnl_Barra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Panel pnl_Barra;
        private System.Windows.Forms.Label lbl_Informes;
        private System.Windows.Forms.Label lbl_Msg;
    }
}