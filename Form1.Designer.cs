namespace Laboratorio02
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.Aluno = new System.Windows.Forms.TabPage();
            this.alunoTextPeriodo = new System.Windows.Forms.TextBox();
            this.alunoTextMatricula = new System.Windows.Forms.TextBox();
            this.AdicionarAluno = new System.Windows.Forms.Button();
            this.alunoTextNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.TabPage();
            this.adicionarMateria = new System.Windows.Forms.Button();
            this.materiaTextCodigo = new System.Windows.Forms.TextBox();
            this.materiaTextNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Relatorio = new System.Windows.Forms.TabPage();
            this.matricular = new System.Windows.Forms.Button();
            this.disciplinasMatriculadas = new System.Windows.Forms.ComboBox();
            this.relatorio1 = new System.Windows.Forms.Label();
            this.listaAlunos = new System.Windows.Forms.ComboBox();
            this.Menu.SuspendLayout();
            this.Aluno.SuspendLayout();
            this.Materia.SuspendLayout();
            this.Relatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AccessibleName = "Menu";
            this.Menu.Controls.Add(this.Aluno);
            this.Menu.Controls.Add(this.Materia);
            this.Menu.Controls.Add(this.Relatorio);
            this.Menu.Location = new System.Drawing.Point(1, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(315, 388);
            this.Menu.TabIndex = 0;
            // 
            // Aluno
            // 
            this.Aluno.AccessibleName = "Aluno";
            this.Aluno.Controls.Add(this.alunoTextPeriodo);
            this.Aluno.Controls.Add(this.alunoTextMatricula);
            this.Aluno.Controls.Add(this.AdicionarAluno);
            this.Aluno.Controls.Add(this.alunoTextNome);
            this.Aluno.Controls.Add(this.label1);
            this.Aluno.Location = new System.Drawing.Point(4, 22);
            this.Aluno.Name = "Aluno";
            this.Aluno.Padding = new System.Windows.Forms.Padding(3);
            this.Aluno.Size = new System.Drawing.Size(307, 362);
            this.Aluno.TabIndex = 0;
            this.Aluno.Text = "Aluno";
            this.Aluno.UseVisualStyleBackColor = true;
            this.Aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // alunoTextPeriodo
            // 
            this.alunoTextPeriodo.Location = new System.Drawing.Point(243, 307);
            this.alunoTextPeriodo.Name = "alunoTextPeriodo";
            this.alunoTextPeriodo.Size = new System.Drawing.Size(52, 20);
            this.alunoTextPeriodo.TabIndex = 4;
            // 
            // alunoTextMatricula
            // 
            this.alunoTextMatricula.Location = new System.Drawing.Point(133, 307);
            this.alunoTextMatricula.Name = "alunoTextMatricula";
            this.alunoTextMatricula.Size = new System.Drawing.Size(104, 20);
            this.alunoTextMatricula.TabIndex = 3;
            // 
            // AdicionarAluno
            // 
            this.AdicionarAluno.Location = new System.Drawing.Point(95, 333);
            this.AdicionarAluno.Name = "AdicionarAluno";
            this.AdicionarAluno.Size = new System.Drawing.Size(109, 23);
            this.AdicionarAluno.TabIndex = 2;
            this.AdicionarAluno.Text = "Adicionar Aluno";
            this.AdicionarAluno.UseVisualStyleBackColor = true;
            this.AdicionarAluno.Click += new System.EventHandler(this.AdicionarAluno_Click);
            // 
            // alunoTextNome
            // 
            this.alunoTextNome.Location = new System.Drawing.Point(7, 307);
            this.alunoTextNome.Name = "alunoTextNome";
            this.alunoTextNome.Size = new System.Drawing.Size(120, 20);
            this.alunoTextNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Materia
            // 
            this.Materia.Controls.Add(this.adicionarMateria);
            this.Materia.Controls.Add(this.materiaTextCodigo);
            this.Materia.Controls.Add(this.materiaTextNome);
            this.Materia.Controls.Add(this.label2);
            this.Materia.Location = new System.Drawing.Point(4, 22);
            this.Materia.Name = "Materia";
            this.Materia.Padding = new System.Windows.Forms.Padding(3);
            this.Materia.Size = new System.Drawing.Size(307, 362);
            this.Materia.TabIndex = 1;
            this.Materia.Text = "Materia";
            this.Materia.UseVisualStyleBackColor = true;
            this.Materia.Click += new System.EventHandler(this.Materia_Click);
            // 
            // adicionarMateria
            // 
            this.adicionarMateria.Location = new System.Drawing.Point(107, 324);
            this.adicionarMateria.Name = "adicionarMateria";
            this.adicionarMateria.Size = new System.Drawing.Size(111, 23);
            this.adicionarMateria.TabIndex = 3;
            this.adicionarMateria.Text = "Adicionar Matéria";
            this.adicionarMateria.UseVisualStyleBackColor = true;
            this.adicionarMateria.Click += new System.EventHandler(this.adicionarMateria_Click);
            // 
            // materiaTextCodigo
            // 
            this.materiaTextCodigo.Location = new System.Drawing.Point(161, 288);
            this.materiaTextCodigo.Name = "materiaTextCodigo";
            this.materiaTextCodigo.Size = new System.Drawing.Size(135, 20);
            this.materiaTextCodigo.TabIndex = 1;
            // 
            // materiaTextNome
            // 
            this.materiaTextNome.Location = new System.Drawing.Point(11, 288);
            this.materiaTextNome.Name = "materiaTextNome";
            this.materiaTextNome.Size = new System.Drawing.Size(144, 20);
            this.materiaTextNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // Relatorio
            // 
            this.Relatorio.Controls.Add(this.matricular);
            this.Relatorio.Controls.Add(this.disciplinasMatriculadas);
            this.Relatorio.Controls.Add(this.relatorio1);
            this.Relatorio.Controls.Add(this.listaAlunos);
            this.Relatorio.Location = new System.Drawing.Point(4, 22);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.Padding = new System.Windows.Forms.Padding(3);
            this.Relatorio.Size = new System.Drawing.Size(307, 362);
            this.Relatorio.TabIndex = 2;
            this.Relatorio.Text = "Relatório";
            this.Relatorio.UseVisualStyleBackColor = true;
            // 
            // matricular
            // 
            this.matricular.Location = new System.Drawing.Point(116, 314);
            this.matricular.Name = "matricular";
            this.matricular.Size = new System.Drawing.Size(75, 23);
            this.matricular.TabIndex = 3;
            this.matricular.Text = "Matricular";
            this.matricular.UseVisualStyleBackColor = true;
            this.matricular.Click += new System.EventHandler(this.matricular_Click);
            // 
            // disciplinasMatriculadas
            // 
            this.disciplinasMatriculadas.FormattingEnabled = true;
            this.disciplinasMatriculadas.Location = new System.Drawing.Point(11, 276);
            this.disciplinasMatriculadas.Name = "disciplinasMatriculadas";
            this.disciplinasMatriculadas.Size = new System.Drawing.Size(285, 21);
            this.disciplinasMatriculadas.TabIndex = 2;
            this.disciplinasMatriculadas.Text = "Disciplinas Disponíveis";
            this.disciplinasMatriculadas.SelectedIndexChanged += new System.EventHandler(this.disciplinasMatriculadas_SelectedIndexChanged);
            // 
            // relatorio1
            // 
            this.relatorio1.AutoSize = true;
            this.relatorio1.Location = new System.Drawing.Point(8, 35);
            this.relatorio1.Name = "relatorio1";
            this.relatorio1.Size = new System.Drawing.Size(0, 13);
            this.relatorio1.TabIndex = 1;
            // 
            // listaAlunos
            // 
            this.listaAlunos.FormattingEnabled = true;
            this.listaAlunos.Location = new System.Drawing.Point(7, 7);
            this.listaAlunos.Name = "listaAlunos";
            this.listaAlunos.Size = new System.Drawing.Size(289, 21);
            this.listaAlunos.TabIndex = 0;
            this.listaAlunos.Text = "Lista de Alunos";
            this.listaAlunos.SelectedIndexChanged += new System.EventHandler(this.listaAlunos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 390);
            this.Controls.Add(this.Menu);
            this.Name = "Form1";
            this.Text = "Cadastro Aluno/Materia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Aluno.ResumeLayout(false);
            this.Aluno.PerformLayout();
            this.Materia.ResumeLayout(false);
            this.Materia.PerformLayout();
            this.Relatorio.ResumeLayout(false);
            this.Relatorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage Aluno;
        private System.Windows.Forms.TabPage Materia;
        private System.Windows.Forms.TabPage Relatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdicionarAluno;
        private System.Windows.Forms.TextBox alunoTextNome;
        private System.Windows.Forms.TextBox alunoTextMatricula;
        private System.Windows.Forms.TextBox alunoTextPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adicionarMateria;
        private System.Windows.Forms.TextBox materiaTextCodigo;
        private System.Windows.Forms.TextBox materiaTextNome;
        private System.Windows.Forms.ComboBox listaAlunos;
        private System.Windows.Forms.Label relatorio1;
        private System.Windows.Forms.Button matricular;
        private System.Windows.Forms.ComboBox disciplinasMatriculadas;
    }
}

