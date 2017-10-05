using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    public class Materia
    {
        private String nome;
        private String codigo;
        int posicao = 0;

        Materia[] lista_materias = new Materia[100];

        public Materia()
        {
            // Construtor Default
        }
        public Materia(String nome, String codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }
        // Getters
        public String getNome()
        {
            return this.nome;
        }
        public String getCodigo()
        {
            return this.codigo;
        }
        public Materia getMaterias(int pos)
        {
            return this.lista_materias[pos];
        }
        public int getPosicao()
        {
            return this.posicao;
        }
        // Setters
        public String setNome(String nome)
        {
            this.nome = nome;
            return this.nome;
        }
        public String setCodigo(String codigo)
        {
            this.codigo = codigo;
            return this.codigo;
        }

        public void adicionaMateria(Materia m1)
        {
            this.lista_materias[this.posicao] = m1;
            this.posicao++;
        }
    }
}
