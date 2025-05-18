namespace Controle_de_Biblioteca.frmPages
{
    partial class frmCadastroDeUsuarios
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
            this.inputNumeroRegistro = new System.Windows.Forms.MaskedTextBox();
            this.inputNumeroMatricula = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.inputDepartamento = new System.Windows.Forms.ComboBox();
            this.labelNumeroRegistro = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.inputCurso = new System.Windows.Forms.ComboBox();
            this.labelNumeroMatricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(263, 343);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 41);
            this.btnCadastrar.TabIndex = 47;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // inputNumeroRegistro
            // 
            this.inputNumeroRegistro.Location = new System.Drawing.Point(263, 296);
            this.inputNumeroRegistro.Mask = "000000000";
            this.inputNumeroRegistro.Name = "inputNumeroRegistro";
            this.inputNumeroRegistro.Size = new System.Drawing.Size(200, 22);
            this.inputNumeroRegistro.TabIndex = 46;
            this.inputNumeroRegistro.ValidatingType = typeof(int);
            this.inputNumeroRegistro.Visible = false;
            // 
            // inputNumeroMatricula
            // 
            this.inputNumeroMatricula.Location = new System.Drawing.Point(263, 296);
            this.inputNumeroMatricula.Mask = "000000000";
            this.inputNumeroMatricula.Name = "inputNumeroMatricula";
            this.inputNumeroMatricula.Size = new System.Drawing.Size(200, 22);
            this.inputNumeroMatricula.TabIndex = 45;
            this.inputNumeroMatricula.ValidatingType = typeof(int);
            this.inputNumeroMatricula.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.MaximumSize = new System.Drawing.Size(800, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(770, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Aqui é possível adicionar novos alunos e/ou professores ao sistema, basta preench" +
    "er as informações corretamente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cadastro de Alunos e Professores";
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Location = new System.Drawing.Point(263, 219);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(93, 16);
            this.labelDepartamento.TabIndex = 42;
            this.labelDepartamento.Text = "Departamento";
            this.labelDepartamento.Visible = false;
            // 
            // inputDepartamento
            // 
            this.inputDepartamento.FormattingEnabled = true;
            this.inputDepartamento.Items.AddRange(new object[] {
            "Engenharia",
            "Computação ou Tecnologia da Informação",
            "Administração",
            "Economia",
            "Educação",
            "Psicologia",
            "Letras",
            "Ciências Biológicas",
            "Direito",
            "Arquitetura e Urbanismo"});
            this.inputDepartamento.Location = new System.Drawing.Point(263, 238);
            this.inputDepartamento.Name = "inputDepartamento";
            this.inputDepartamento.Size = new System.Drawing.Size(200, 24);
            this.inputDepartamento.TabIndex = 41;
            this.inputDepartamento.Visible = false;
            // 
            // labelNumeroRegistro
            // 
            this.labelNumeroRegistro.AutoSize = true;
            this.labelNumeroRegistro.Location = new System.Drawing.Point(263, 277);
            this.labelNumeroRegistro.Name = "labelNumeroRegistro";
            this.labelNumeroRegistro.Size = new System.Drawing.Size(128, 16);
            this.labelNumeroRegistro.TabIndex = 40;
            this.labelNumeroRegistro.Text = "Número de Registro";
            this.labelNumeroRegistro.Visible = false;
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(260, 219);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(42, 16);
            this.labelCurso.TabIndex = 39;
            this.labelCurso.Text = "Curso";
            this.labelCurso.Visible = false;
            // 
            // inputCurso
            // 
            this.inputCurso.FormattingEnabled = true;
            this.inputCurso.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Modas",
            "Arquitetura e Urbanismo",
            "Administratação",
            "Comércio Exterior"});
            this.inputCurso.Location = new System.Drawing.Point(263, 238);
            this.inputCurso.Name = "inputCurso";
            this.inputCurso.Size = new System.Drawing.Size(200, 24);
            this.inputCurso.TabIndex = 38;
            this.inputCurso.Visible = false;
            // 
            // labelNumeroMatricula
            // 
            this.labelNumeroMatricula.AutoSize = true;
            this.labelNumeroMatricula.Location = new System.Drawing.Point(260, 277);
            this.labelNumeroMatricula.Name = "labelNumeroMatricula";
            this.labelNumeroMatricula.Size = new System.Drawing.Size(131, 16);
            this.labelNumeroMatricula.TabIndex = 37;
            this.labelNumeroMatricula.Text = "Número de Mátricula";
            this.labelNumeroMatricula.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tipo";
            // 
            // inputType
            // 
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Aluno",
            "Professor"});
            this.inputType.Location = new System.Drawing.Point(263, 180);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(200, 24);
            this.inputType.TabIndex = 35;
            this.inputType.SelectedIndexChanged += new System.EventHandler(this.inputType_SelectedIndexChanged);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(263, 120);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(200, 22);
            this.inputName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome";
            // 
            // frmCadastroDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.inputNumeroRegistro);
            this.Controls.Add(this.inputNumeroMatricula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelDepartamento);
            this.Controls.Add(this.inputDepartamento);
            this.Controls.Add(this.labelNumeroRegistro);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.inputCurso);
            this.Controls.Add(this.labelNumeroMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroDeUsuarios";
            this.Text = "Cadastro de Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox inputNumeroRegistro;
        private System.Windows.Forms.MaskedTextBox inputNumeroMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.ComboBox inputDepartamento;
        private System.Windows.Forms.Label labelNumeroRegistro;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.ComboBox inputCurso;
        private System.Windows.Forms.Label labelNumeroMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label1;
    }
}