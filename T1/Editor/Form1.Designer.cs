namespace Editor
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
            this.btnSalvarTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(13, 13);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(326, 252);
            this.tbTexto.TabIndex = 0;
            // 
            // btnSalvarTxt
            // 
            this.btnSalvarTxt.Location = new System.Drawing.Point(135, 278);
            this.btnSalvarTxt.Name = "btnSalvarTxt";
            this.btnSalvarTxt.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTxt.TabIndex = 1;
            this.btnSalvarTxt.Text = "Salvar";
            this.btnSalvarTxt.UseVisualStyleBackColor = true;
            this.btnSalvarTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 313);
            this.Controls.Add(this.btnSalvarTxt);
            this.Controls.Add(this.tbTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Editor de textos";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btnSalvarTxt;
    }
}

