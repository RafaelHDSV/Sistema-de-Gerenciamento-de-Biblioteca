namespace Controle_de_Biblioteca.frmPages
{
    partial class Relatórios
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
            this.dtGridAlunos = new System.Windows.Forms.DataGridView();
            this.dtGridLivros = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGridProfessores = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridEmprestimos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGridLivrosDisponiveis = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtGridLivrosEmprestados = new System.Windows.Forms.DataGridView();
            this.noDataAlunos = new System.Windows.Forms.Label();
            this.noDataProfessores = new System.Windows.Forms.Label();
            this.noDataLivros = new System.Windows.Forms.Label();
            this.noDataLivrosDisponiveis = new System.Windows.Forms.Label();
            this.noDataLivrosEmprestados = new System.Windows.Forms.Label();
            this.noDataHistoricoDeEmprestimos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmprestimos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivrosDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivrosEmprestados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridAlunos
            // 
            this.dtGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAlunos.Location = new System.Drawing.Point(12, 109);
            this.dtGridAlunos.Name = "dtGridAlunos";
            this.dtGridAlunos.RowHeadersWidth = 51;
            this.dtGridAlunos.RowTemplate.Height = 24;
            this.dtGridAlunos.Size = new System.Drawing.Size(950, 145);
            this.dtGridAlunos.TabIndex = 0;
            this.dtGridAlunos.Visible = false;
            this.dtGridAlunos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtGridAlunos_DataBindingComplete);
            // 
            // dtGridLivros
            // 
            this.dtGridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLivros.Location = new System.Drawing.Point(12, 299);
            this.dtGridLivros.Name = "dtGridLivros";
            this.dtGridLivros.RowHeadersWidth = 51;
            this.dtGridLivros.RowTemplate.Height = 24;
            this.dtGridLivros.Size = new System.Drawing.Size(950, 145);
            this.dtGridLivros.TabIndex = 1;
            this.dtGridLivros.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.MaximumSize = new System.Drawing.Size(800, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(691, 18);
            this.label8.TabIndex = 61;
            this.label8.Text = "Aqui é possível ver os dados salvos no banco atualmente, lembre-se de atualizar a" +
    " tela após alterações.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 29);
            this.label7.TabIndex = 60;
            this.label7.Text = "Relatórios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.MaximumSize = new System.Drawing.Size(800, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.MaximumSize = new System.Drawing.Size(800, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Livros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1017, 88);
            this.label3.MaximumSize = new System.Drawing.Size(800, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Professores";
            // 
            // dtGridProfessores
            // 
            this.dtGridProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProfessores.Location = new System.Drawing.Point(1020, 109);
            this.dtGridProfessores.Name = "dtGridProfessores";
            this.dtGridProfessores.RowHeadersWidth = 51;
            this.dtGridProfessores.RowTemplate.Height = 24;
            this.dtGridProfessores.Size = new System.Drawing.Size(950, 145);
            this.dtGridProfessores.TabIndex = 64;
            this.dtGridProfessores.Visible = false;
            this.dtGridProfessores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtGridProfessores_DataBindingComplete);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1895, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 66;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1017, 472);
            this.label4.MaximumSize = new System.Drawing.Size(800, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Histórico de Empréstimos";
            // 
            // dtGridEmprestimos
            // 
            this.dtGridEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEmprestimos.Location = new System.Drawing.Point(1020, 493);
            this.dtGridEmprestimos.Name = "dtGridEmprestimos";
            this.dtGridEmprestimos.RowHeadersWidth = 51;
            this.dtGridEmprestimos.RowTemplate.Height = 24;
            this.dtGridEmprestimos.Size = new System.Drawing.Size(950, 145);
            this.dtGridEmprestimos.TabIndex = 67;
            this.dtGridEmprestimos.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1020, 278);
            this.label5.MaximumSize = new System.Drawing.Size(800, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Livros Disponíveis";
            // 
            // dtGridLivrosDisponiveis
            // 
            this.dtGridLivrosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLivrosDisponiveis.Location = new System.Drawing.Point(1020, 299);
            this.dtGridLivrosDisponiveis.Name = "dtGridLivrosDisponiveis";
            this.dtGridLivrosDisponiveis.RowHeadersWidth = 51;
            this.dtGridLivrosDisponiveis.RowTemplate.Height = 24;
            this.dtGridLivrosDisponiveis.Size = new System.Drawing.Size(950, 145);
            this.dtGridLivrosDisponiveis.TabIndex = 69;
            this.dtGridLivrosDisponiveis.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 472);
            this.label6.MaximumSize = new System.Drawing.Size(800, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Livros Emprestados";
            // 
            // dtGridLivrosEmprestados
            // 
            this.dtGridLivrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLivrosEmprestados.Location = new System.Drawing.Point(12, 493);
            this.dtGridLivrosEmprestados.Name = "dtGridLivrosEmprestados";
            this.dtGridLivrosEmprestados.RowHeadersWidth = 51;
            this.dtGridLivrosEmprestados.RowTemplate.Height = 24;
            this.dtGridLivrosEmprestados.Size = new System.Drawing.Size(950, 145);
            this.dtGridLivrosEmprestados.TabIndex = 71;
            this.dtGridLivrosEmprestados.Visible = false;
            // 
            // noDataAlunos
            // 
            this.noDataAlunos.AutoSize = true;
            this.noDataAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataAlunos.Location = new System.Drawing.Point(12, 121);
            this.noDataAlunos.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataAlunos.Name = "noDataAlunos";
            this.noDataAlunos.Size = new System.Drawing.Size(404, 25);
            this.noDataAlunos.TabIndex = 73;
            this.noDataAlunos.Text = "Não existem dados para a tabela de \"Alunos\"";
            this.noDataAlunos.Visible = false;
            // 
            // noDataProfessores
            // 
            this.noDataProfessores.AutoSize = true;
            this.noDataProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataProfessores.Location = new System.Drawing.Point(1018, 121);
            this.noDataProfessores.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataProfessores.Name = "noDataProfessores";
            this.noDataProfessores.Size = new System.Drawing.Size(426, 25);
            this.noDataProfessores.TabIndex = 74;
            this.noDataProfessores.Text = "Não existem dados para a tabela de \"Professor\"";
            this.noDataProfessores.Visible = false;
            // 
            // noDataLivros
            // 
            this.noDataLivros.AutoSize = true;
            this.noDataLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataLivros.Location = new System.Drawing.Point(12, 310);
            this.noDataLivros.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataLivros.Name = "noDataLivros";
            this.noDataLivros.Size = new System.Drawing.Size(395, 25);
            this.noDataLivros.TabIndex = 75;
            this.noDataLivros.Text = "Não existem dados para a tabela de \"Livros\"";
            this.noDataLivros.Visible = false;
            // 
            // noDataLivrosDisponiveis
            // 
            this.noDataLivrosDisponiveis.AutoSize = true;
            this.noDataLivrosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataLivrosDisponiveis.Location = new System.Drawing.Point(1018, 310);
            this.noDataLivrosDisponiveis.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataLivrosDisponiveis.Name = "noDataLivrosDisponiveis";
            this.noDataLivrosDisponiveis.Size = new System.Drawing.Size(500, 25);
            this.noDataLivrosDisponiveis.TabIndex = 76;
            this.noDataLivrosDisponiveis.Text = "Não existem dados para a tabela de \"Livros Disponíveis\"";
            this.noDataLivrosDisponiveis.Visible = false;
            // 
            // noDataLivrosEmprestados
            // 
            this.noDataLivrosEmprestados.AutoSize = true;
            this.noDataLivrosEmprestados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataLivrosEmprestados.Location = new System.Drawing.Point(12, 505);
            this.noDataLivrosEmprestados.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataLivrosEmprestados.Name = "noDataLivrosEmprestados";
            this.noDataLivrosEmprestados.Size = new System.Drawing.Size(515, 25);
            this.noDataLivrosEmprestados.TabIndex = 77;
            this.noDataLivrosEmprestados.Text = "Não existem dados para a tabela de \"Livros Emprestados\"";
            this.noDataLivrosEmprestados.Visible = false;
            // 
            // noDataHistoricoDeEmprestimos
            // 
            this.noDataHistoricoDeEmprestimos.AutoSize = true;
            this.noDataHistoricoDeEmprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDataHistoricoDeEmprestimos.Location = new System.Drawing.Point(1018, 505);
            this.noDataHistoricoDeEmprestimos.MaximumSize = new System.Drawing.Size(800, 0);
            this.noDataHistoricoDeEmprestimos.Name = "noDataHistoricoDeEmprestimos";
            this.noDataHistoricoDeEmprestimos.Size = new System.Drawing.Size(563, 25);
            this.noDataHistoricoDeEmprestimos.TabIndex = 78;
            this.noDataHistoricoDeEmprestimos.Text = "Não existem dados para a tabela de \"Histórico de Empréstimos\"";
            this.noDataHistoricoDeEmprestimos.Visible = false;
            // 
            // Relatórios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1982, 716);
            this.Controls.Add(this.noDataHistoricoDeEmprestimos);
            this.Controls.Add(this.noDataLivrosEmprestados);
            this.Controls.Add(this.noDataLivrosDisponiveis);
            this.Controls.Add(this.noDataLivros);
            this.Controls.Add(this.noDataProfessores);
            this.Controls.Add(this.noDataAlunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtGridLivrosEmprestados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtGridLivrosDisponiveis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridEmprestimos);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtGridProfessores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtGridLivros);
            this.Controls.Add(this.dtGridAlunos);
            this.Name = "Relatórios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEmprestimos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivrosDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLivrosEmprestados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridAlunos;
        private System.Windows.Forms.DataGridView dtGridLivros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtGridProfessores;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGridEmprestimos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtGridLivrosDisponiveis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGridLivrosEmprestados;
        private System.Windows.Forms.Label noDataAlunos;
        private System.Windows.Forms.Label noDataProfessores;
        private System.Windows.Forms.Label noDataLivros;
        private System.Windows.Forms.Label noDataLivrosDisponiveis;
        private System.Windows.Forms.Label noDataLivrosEmprestados;
        private System.Windows.Forms.Label noDataHistoricoDeEmprestimos;
    }
}