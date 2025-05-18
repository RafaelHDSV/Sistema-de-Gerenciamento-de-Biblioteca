namespace Controle_de_Biblioteca.frmPages
{
    partial class frmControleDeEmpréstimo
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLivro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(279, 265);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(200, 41);
            this.btnAtualizar.TabIndex = 62;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 40);
            this.label8.MaximumSize = new System.Drawing.Size(800, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(674, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Aqui é possível alterar o status de um livro no sistema, basta preencher as infor" +
    "mações corretamente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(440, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "Controle de Empréstimos e Devoluções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Status";
            // 
            // inputStatus
            // 
            this.inputStatus.FormattingEnabled = true;
            this.inputStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Emprestado"});
            this.inputStatus.Location = new System.Drawing.Point(279, 228);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Size = new System.Drawing.Size(200, 24);
            this.inputStatus.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Livro";
            // 
            // inputLivro
            // 
            this.inputLivro.FormattingEnabled = true;
            this.inputLivro.Location = new System.Drawing.Point(279, 168);
            this.inputLivro.Name = "inputLivro";
            this.inputLivro.Size = new System.Drawing.Size(200, 24);
            this.inputLivro.TabIndex = 63;
            this.inputLivro.SelectedIndexChanged += new System.EventHandler(this.inputLivro_SelectedIndexChanged);
            // 
            // frmControleDeEmpréstimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputLivro);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputStatus);
            this.Controls.Add(this.label1);
            this.Name = "frmControleDeEmpréstimo";
            this.Text = "Controle de Empréstimo";
            this.Load += new System.EventHandler(this.frmControleDeEmpréstimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputLivro;
    }
}