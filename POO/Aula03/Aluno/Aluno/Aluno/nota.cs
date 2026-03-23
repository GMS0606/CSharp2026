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

        //Método 

        public void MostrarNotas()
        {
            Console.WriteLine("Notas do aluno:");

            Console.WriteLine(nota1);
            Console.WriteLine(nota2);
            Console.WriteLine(nota3);

        }
    }
}