namespace CaixaEletronico
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroConta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDeposito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSacar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbContas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Realizar deposito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero da conta";
            // 
            // tbNumeroConta
            // 
            this.tbNumeroConta.Location = new System.Drawing.Point(183, 40);
            this.tbNumeroConta.Name = "tbNumeroConta";
            this.tbNumeroConta.ReadOnly = true;
            this.tbNumeroConta.Size = new System.Drawing.Size(110, 20);
            this.tbNumeroConta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo da conta";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(318, 40);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(110, 20);
            this.tbSaldo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depositar";
            // 
            // tbDeposito
            // 
            this.tbDeposito.Location = new System.Drawing.Point(45, 101);
            this.tbDeposito.Name = "tbDeposito";
            this.tbDeposito.Size = new System.Drawing.Size(110, 20);
            this.tbDeposito.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sacar";
            // 
            // tbSacar
            // 
            this.tbSacar.Location = new System.Drawing.Point(183, 101);
            this.tbSacar.Name = "tbSacar";
            this.tbSacar.Size = new System.Drawing.Size(110, 20);
            this.tbSacar.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Realizar saque";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Total nas contas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbContas
            // 
            this.cbContas.BackColor = System.Drawing.SystemColors.Window;
            this.cbContas.FormattingEnabled = true;
            this.cbContas.Location = new System.Drawing.Point(45, 39);
            this.cbContas.Name = "cbContas";
            this.cbContas.Size = new System.Drawing.Size(110, 21);
            this.cbContas.TabIndex = 11;
            this.cbContas.SelectedIndexChanged += new System.EventHandler(this.cbContas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 255);
            this.Controls.Add(this.cbContas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbSacar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDeposito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumeroConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Caixa Eletronico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeposito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSacar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbContas;
    }
}

