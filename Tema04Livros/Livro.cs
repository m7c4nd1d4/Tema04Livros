using System;
using System.Collections.Generic;
using System.Text;

namespace Tema04Livros
{
    class Livro
    {
        private string nome, autores; // campo ou atributos
        private double preco;
        public Livro(string nome, string autores, double preco)
        {
            if (nome != null) this.nome = nome;
            if (autores != null) this.autores = autores;
            if (preco > 0) this.preco = preco;
        }
        public double GetPreco()
        {
            return preco;
        }
        public override string ToString()
        {
            return $"{nome} - {autores} - {preco}";
        }
    }
}