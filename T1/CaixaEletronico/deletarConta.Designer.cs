namespace CaixaEletronico
{
    partial class DeletarConta
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
            this.lbDelCon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbConfDelet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDelCon
            // 
            this.lbDelCon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelCon.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbDelCon.Location = new System.Drawing.Point(12, 9);
            this.lbDelCon.Name = "lbDelCon";
            this.lbDelCon.Size = new System.Drawing.Size(309, 70);
            this.lbDelCon.TabIndex = 0;
            this.lbDelCon.Text = "Para deletar a conta de cabrita montanheira por favor insira o numero de sua cont" +
    "a abaixo.";
            this.lbDelCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbConfDelet
            // 
            this.tbConfDelet.Location = new System.Drawing.Point(119, 104);
            this.tbConfDelet.Name = "tbConfDelet";
            this.tbConfDelet.Size = new System.Drawing.Size(100, 20);
            this.tbConfDelet.TabIndex = 2;
            // 
            // DeletarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 181);
            this.Controls.Add(this.tbConfDelet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDelCon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeletarConta";
            this.Text = "Deletar conta";
            this.Load += new System.EventHandler(this.deletarConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDelCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbConfDelet;
    }
}