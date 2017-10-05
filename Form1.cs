using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio02
{
    public partial class Form1 : Form
    {
        public Aluno alN = new Aluno();
        public Materia mN = new Materia();
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Aluno a1 = new Aluno("Eduardo Ribeiro", "11621ECP001", 3);
            Aluno a2 = new Aluno("Walber Diniz", "11721ECP010", 1);
            Aluno a3 = new Aluno("Romario Aquino", "11411ECP019", 10);

            Materia m1 = new Materia("Matematica", "000001");
            Materia m2 = new Materia("Fisica", "000002");
            Materia m3 = new Materia("Geografia", "000003");

            a1.setListaMateria(m1);
            a2.setListaMateria(m2);
            a2.setListaMateria(m3);

            alN.adicionaAluno(a1);
            alN.adicionaAluno(a2);
            alN.adicionaAluno(a3);

            mN.adicionaMateria(m1);
            mN.adicionaMateria(m2);
            mN.adicionaMateria(m3);
            
            exibeAluno();
            exibeMateria();
            exibeAlunoCombo();
            exibeMateriaCombo();
        }
        
        public void exibeAluno()
        {
            label1.Text = "";
            for (int i = 0; i < alN.getPosicaoAlunos(); i++)
            {
                label1.Text = label1.Text + alN.getListaAlunos(i).getNome() + " - " + alN.getListaAlunos(i).getNumeroMatricula() +
                       " - " + alN.getListaAlunos(i).getPeriodo() + "º período\n";
            }
        }

        public void exibeAlunoCombo()
        {
            listaAlunos.Items.Clear();
            for (int i = 0; i < alN.getPosicaoAlunos(); i++)
            {
                listaAlunos.Items.Add(alN.getListaAlunos(i).getNome() + " - " +
                    alN.getListaAlunos(i).getNumeroMatricula() + " - " +
                    alN.getListaAlunos(i).getPeriodo() + "º período");
            }
        }

        public void exibeMateria()
        {
            label2.Text = "";
            for (int i = 0; i < mN.getPosicao(); i++)
            {
                label2.Text = label2.Text + mN.getMaterias(i).getNome() + " - " + mN.getMaterias(i).getCodigo() + "\n";
            }
        }

        public void exibeMateriaCombo()
        {
            disciplinasMatriculadas.Items.Clear();
            for (int i = 0; i < mN.getPosicao(); i++)
            {
                disciplinasMatriculadas.Items.Add(mN.getMaterias(i).getNome() + " - " +
                    mN.getMaterias(i).getCodigo());
            }
        }

        private void Aluno_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AdicionarAluno_Click(object sender, EventArgs e)
        {
            string nome, matricula;
            int periodo;

            nome = alunoTextNome.Text;
            matricula = alunoTextMatricula.Text;
            periodo = Convert.ToInt32(alunoTextPeriodo.Text);

            label1.Text = label1.Text + "\n" + nome + " - " + matricula + " - " + periodo + "º período\n";

            Aluno a1 = new Aluno(nome, matricula, periodo);

            alN.adicionaAluno(a1);
            exibeAluno();
            exibeAlunoCombo();
            exibeMateriaCombo();
        }

        private void Materia_Click(object sender, EventArgs e)
        {

        }

        private void adicionarMateria_Click(object sender, EventArgs e)
        {
            string nome, codigo;
            
            nome = materiaTextNome.Text;
            codigo = materiaTextCodigo.Text;

            label2.Text = label2.Text + "\n" + nome + " - " + codigo + "\n";

            Materia m1 = new Materia(nome, codigo);
            
            mN.adicionaMateria(m1);
            exibeMateria();
            exibeAlunoCombo();
            exibeMateriaCombo();
        }

        public void mostraDadosAluno()
        {
            int selectedIndex = listaAlunos.SelectedIndex;
            Object selectedItem = listaAlunos.SelectedItem;

            relatorio1.Text = "Nome: " + alN.getListaAlunos(selectedIndex).getNome() +
                "\nMatricula: " + alN.getListaAlunos(selectedIndex).getNumeroMatricula() +
                "\nPeríodo: " + alN.getListaAlunos(selectedIndex).getPeriodo() +
                "º\n\n---------------------------- Matérias Matriculadas ----------------------------\n";
            for (int i = 0; i < alN.getPosicaoMateria(); i++)
            {
                relatorio1.Text += alN.getListaMaterias(i).getNome() + " - " +
                   alN.getListaMaterias(i).getCodigo() + "\n";
            }
            if (alN.getListaAlunos(selectedIndex).getPosicaoMateria() == 0)
            {
                relatorio1.Text += "O aluno não esta matriculado em nenhuma matéria.\n";
            }
            else
            {
                for (int i = 0; i < alN.getListaAlunos(selectedIndex).getPosicaoMateria(); i++)
                {
                    relatorio1.Text += "Materia: " + alN.getListaAlunos(selectedIndex).getListaMaterias(i).getNome() +
                        " - Código: " + alN.getListaAlunos(selectedIndex).getListaMaterias(i).getCodigo() + "\n";
                }
            }
        }

        private void listaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostraDadosAluno();
        }

        private void disciplinasMatriculadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int disciplinaIndex = disciplinasMatriculadas.SelectedIndex;
            int alunoIndex = listaAlunos.SelectedIndex;
            Object selectedItem = disciplinasMatriculadas.SelectedItem;
        }

        private void matricular_Click(object sender, EventArgs e)
        {
            int disciplinaIndex = disciplinasMatriculadas.SelectedIndex;
            int alunoIndex = listaAlunos.SelectedIndex;

            Aluno a1 = alN.getListaAlunos(alunoIndex);
            int numeroMateriasAluno = a1.getPosicaoMateria();
            Materia materia = mN.getMaterias(disciplinaIndex);
            string materiaNome = materia.getNome();
            int contador = 0;
            
            for(int i = 0; i < numeroMateriasAluno; i++)
            {
                if (a1.getListaMaterias(i).getNome().Equals(materiaNome))
                {
                    contador++;
                }
            }

            if(contador == 0)
            {
                a1.setListaMateria(materia);
            }else
            {
                MessageBox.Show("O Aluno já esta matriculado na disciplina!");
            }
            mostraDadosAluno();
        }
    }
}
