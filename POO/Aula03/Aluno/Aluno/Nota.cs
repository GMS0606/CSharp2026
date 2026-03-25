using System;
using System.Collections.Generic;
using System.Text;

namespace Aluno
{
    internal class Nota
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        // Construtor 
        public Nota(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        // Métodos 
        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool AprovadoOuReprovado()
        {
            return NotaFinal() >= 60.0;
        }

        public double Ponto()
        {
            if (AprovadoOuReprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}