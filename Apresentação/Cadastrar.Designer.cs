namespace ProjetoTelaDeLogin.Apresentação
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbLoginCadastro = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.txbSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // txbLoginCadastro
            // 
            this.txbLoginCadastro.Location = new System.Drawing.Point(33, 48);
            this.txbLoginCadastro.Name = "txbLoginCadastro";
            this.txbLoginCadastro.Size = new System.Drawing.Size(218, 20);
            this.txbLoginCadastro.TabIndex = 1;
            this.txbLoginCadastro.TextChanged += new System.EventHandler(this.txbLoginCadastro_TextChanged);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(33, 226);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(228, 23);
            this.btnConcluir.TabIndex = 2;
            this.btnConcluir.Text = "Concluir Cadastro";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // txbSenhaCadastro
            // 
            this.txbSenhaCadastro.Location = new System.Drawing.Point(33, 102);
            this.txbSenhaCadastro.Name = "txbSenhaCadastro";
            this.txbSenhaCadastro.Size = new System.Drawing.Size(218, 20);
            this.txbSenhaCadastro.TabIndex = 3;
            this.txbSenhaCadastro.TextChanged += new System.EventHandler(this.txbSenhaCadastro_TextChanged);
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(33, 165);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.Size = new System.Drawing.Size(218, 20);
            this.txbConfirmar.TabIndex = 4;
            this.txbConfirmar.TextChanged += new System.EventHandler(this.txbConfirmar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirmar Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbConfirmar);
            this.Controls.Add(this.txbSenhaCadastro);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txbLoginCadastro);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLoginCadastro;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.TextBox txbSenhaCadastro;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}