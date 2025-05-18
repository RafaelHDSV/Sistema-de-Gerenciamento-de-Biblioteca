namespace Controle_de_Biblioteca.frmPages
{
    partial class frmCadastroDeLivros
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.labelNumeroRegistro = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTitulo = new System.Windows.Forms.TextBox();
            this.inputAno = new System.Windows.Forms.MaskedTextBox();
            this.inputStatus = new System.Windows.Forms.ComboBox();
            this.inputAutor = new System.Windows.Forms.TextBox();
            this.inputISBN = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(263, 354);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 41);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.MaximumSize = new System.Drawing.Size(800, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(644, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Aqui é possível adicionar novos livros ao sistema, basta preencher as informações" +
    " corretamente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cadastro de Livros";
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Location = new System.Drawing.Point(143, 162);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(31, 16);
            this.labelDepartamento.TabIndex = 27;
            this.labelDepartamento.Text = "Ano";
            // 
            // labelNumeroRegistro
            // 
            this.labelNumeroRegistro.AutoSize = true;
            this.labelNumeroRegistro.Location = new System.Drawing.Point(143, 215);
            this.labelNumeroRegistro.Name = "labelNumeroRegistro";
            this.labelNumeroRegistro.Size = new System.Drawing.Size(44, 16);
            this.labelNumeroRegistro.TabIndex = 25;
            this.labelNumeroRegistro.Text = "Status";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(408, 162);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(38, 16);
            this.labelCurso.TabIndex = 24;
            this.labelCurso.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Título";
            // 
            // inputTitulo
            // 
            this.inputTitulo.Location = new System.Drawing.Point(146, 125);
            this.inputTitulo.Name = "inputTitulo";
            this.inputTitulo.Size = new System.Drawing.Size(200, 22);
            this.inputTitulo.TabIndex = 33;
            // 
            // inputAno
            // 
            this.inputAno.Location = new System.Drawing.Point(146, 181);
            this.inputAno.Mask = "0000";
            this.inputAno.Name = "inputAno";
            this.inputAno.Size = new System.Drawing.Size(200, 22);
            this.inputAno.TabIndex = 35;
            // 
            // inputStatus
            // 
            this.inputStatus.FormattingEnabled = true;
            this.inputStatus.Items.AddRange(new object[] {
            "Disponivel",
            "Emprestado"});
            this.inputStatus.Location = new System.Drawing.Point(146, 234);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Size = new System.Drawing.Size(200, 24);
            this.inputStatus.TabIndex = 37;
            // 
            // inputAutor
            // 
            this.inputAutor.Location = new System.Drawing.Point(411, 125);
            this.inputAutor.Name = "inputAutor";
            this.inputAutor.Size = new System.Drawing.Size(200, 22);
            this.inputAutor.TabIndex = 34;
            // 
            // inputISBN
            // 
            this.inputISBN.Location = new System.Drawing.Point(411, 181);
            this.inputISBN.Mask = "000-0000000000";
            this.inputISBN.Name = "inputISBN";
            this.inputISBN.Size = new System.Drawing.Size(200, 22);
            this.inputISBN.TabIndex = 36;
            // 
            // frmCadastroDeLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputISBN);
            this.Controls.Add(this.inputAutor);
            this.Controls.Add(this.inputStatus);
            this.Controls.Add(this.inputAno);
            this.Controls.Add(this.inputTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDepartamento);
            this.Controls.Add(this.labelNumeroRegistro);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDeLivros";
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.frmCadastroDeLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelNumeroRegistro;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTitulo;
        private System.Windows.Forms.MaskedTextBox inputAno;
        private System.Windows.Forms.ComboBox inputStatus;
        private System.Windows.Forms.TextBox inputAutor;
        private System.Windows.Forms.MaskedTextBox inputISBN;
    }
}