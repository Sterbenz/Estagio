﻿namespace Editor
{
    partial class Form1
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
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(12, 12);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(277, 203);
            this.tbTexto.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(119, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 265);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btnSalvar;
    }
}

