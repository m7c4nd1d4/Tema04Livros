using System;
using System.Collections.Generic;
using System.Text;

namespace Tema04Livros
{
    class Genero
    {
        private int k = 0;
        private string nome; // campo ou atributos
        public Livro[] livros = new Livro[2];
        public Genero(string valor)
        {
            nome = valor;
        
        }
        public void Inserir(Livro l)
        {
            livros[k] = l;
            k++;
        }
        public Livro[] Listar()
        {
            return livros;
        }

        public override string ToString()
        {
            return $"Gênero: {nome}";
        }
        public Livro MenorPreco()
        {
            Livro menor = livros[0];
            for (int i =1; i<=k - 1; i++)
            {
                if (livros[i].GetPreco() < menor.GetPreco()) menor = livros[i];
            }
            return menor;

        }
    }
}