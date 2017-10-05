using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    public class Aluno
    {
        private String nome;
        private String numero_matricula;
        private int periodo;
        Materia[] lista_materias = new Materia[8];
        Aluno[] lista_alunos = new Aluno[100];
        private int posicao = 0, posicao_aluno = 0;

        //Construtor
        public Aluno()
        {
            // Construtor Default
        }
        public Aluno(String nome, String numero_matricula, int periodo)
        {
            this.nome = nome;
            this.periodo = periodo;
            this.numero_matricula = numero_matricula;
        }
        // Setters
        public string setNome(String nome)
        {
            this.nome = nome;
            return this.nome;
        }
        public String setNumeroMatricula(String numero_matricula)
        {
            this.numero_matricula = numero_matricula;
            return this.numero_matricula;
        }
        public int setPeriodo(int periodo)
        {
            this.periodo = periodo;
            return this.periodo;
        }
        public void setListaMateria(Materia mat)
        {
            this.lista_materias[this.posicao] = mat;
            this.posicao++;
        }
        // Getters
        public String getNome()
        {
            return this.nome;
        }
        public String getNumeroMatricula()
        {
            return this.numero_matricula;
        }
        public int getPeriodo()
        {
            return this.periodo;
        }
        public Materia getListaMaterias(int pos)
        {
            return this.lista_materias[pos];
        }
        public Aluno getListaAlunos(int pos)
        {
            return this.lista_alunos[pos];
        }
        public int getPosicaoMateria()
        {
            return this.posicao;
        }
        public int getPosicaoAlunos()
        {
            return this.posicao_aluno;
        }
        //Metodos
        public void adicionaAluno(Aluno a1)
        {
            this.lista_alunos[this.posicao_aluno] = a1;
            this.posicao_aluno++;
        }
    }
}
