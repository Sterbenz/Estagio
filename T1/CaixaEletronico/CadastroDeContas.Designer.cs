﻿namespace CaixaEletronico
{
    partial class CadastroDeContas
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
            this.tbCadTit = new System.Windows.Forms.TextBox();
            this.tbCadNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCadSald = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCadTit
            // 
            this.tbCadTit.Location = new System.Drawing.Point(6, 72);
            this.tbCadTit.Name = "tbCadTit";
            this.tbCadTit.Size = new System.Drawing.Size(120, 20);
            this.tbCadTit.TabIndex = 0;
            // 
            // tbCadNum
            // 
            this.tbCadNum.Location = new System.Drawing.Point(135, 72);
            this.tbCadNum.Name = "tbCadNum";
            this.tbCadNum.Size = new System.Drawing.Size(120, 20);
            this.tbCadNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do titular da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número da conta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar conta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCadSald
            // 
            this.tbCadSald.Location = new System.Drawing.Point(263, 72);
            this.tbCadSald.Name = "tbCadSald";
            this.tbCadSald.Size = new System.Drawing.Size(120, 20);
            this.tbCadSald.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo da conta";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCadSald);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCadNum);
            this.Controls.Add(this.tbCadTit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCadTit;
        private System.Windows.Forms.TextBox tbCadNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCadSald;
        private System.Windows.Forms.Label label3;
    }
}