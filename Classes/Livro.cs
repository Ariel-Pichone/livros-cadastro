using System;

namespace Livros
{
    public class Livro : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Editora { get; set; }
        private Idioma Idioma { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Livro (int id, Genero genero, string titulo, string autor, string editora, Idioma idioma, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Idioma = idioma;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Editora: " + this.Editora + Environment.NewLine;
            retorno += "Idioma: " + this.Idioma + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
			return retorno;
		}
        
            public string retornaTitulo()
            {
                return this.Titulo;
            }

            public int retornaId()
            {
                return this.Id;
            }
            public void Excluir()
            {
                this.Excluido = true;
            }
    }
}