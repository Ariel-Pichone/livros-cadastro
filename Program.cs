using System;

namespace Livros
{
    class Program
    {
        static LivroRepositorio repositorio = new LivroRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarLivros();
						break;
					case "2":
						InserirLivro();
						break;
					case "3":
						AtualizarLivro();
						break;
					case "4":
						ExcluirLivro();
						break;
					case "5":
						VisualizarLivro();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar livros");
			Console.WriteLine("2- Inserir novo livro");
			Console.WriteLine("3- Atualizar livro");
			Console.WriteLine("4- Excluir livro");
			Console.WriteLine("5- Visualizar livro");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

        private static void ListarLivros()
		{
			Console.WriteLine("Listar livros");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum livro cadastrado.");
				return;
			}

			foreach (var livro in lista)
			{
                var excluido = livro.retornaExcluido();
                //caso excluido = true vai mostrar "*Excluido*" caso contrario ""
				Console.WriteLine("#ID {0}: - {1} {2}", livro.retornaId(), livro.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirLivro()
		{
			Console.WriteLine("Inserir novo livro");

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Livro: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Autor do Livro: ");
			string entradaAutor = Console.ReadLine();

            Console.Write("Digite a Editora do Livro: ");
			string entradaEditora = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Idioma)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Idioma), i));
			}
            Console.Write("Digite o idioma entre as opções acima: ");
			int entradaIdioma = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano do Livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Livro: ");
			string entradaDescricao = Console.ReadLine();

			Livro novaSerie = new Livro(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
                                        autor: entradaAutor,
                                        editora: entradaEditora,
                                        idioma: (Idioma)entradaIdioma,
                                        descricao: entradaDescricao,
										ano: entradaAno);
										
			repositorio.Insere(novaSerie);
		}

        private static void AtualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Livro: ");
			string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Autor do Livro: ");
			string entradaAutor = Console.ReadLine();

            Console.Write("Digite a Editora do Livro: ");
			string entradaEditora = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Idioma)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Idioma), i));
			}
            Console.Write("Digite o idioma entre as opções acima: ");
			int entradaIdioma = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano do Livro: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Livro: ");
			string entradaDescricao = Console.ReadLine();

			Livro atualizaLivro = new Livro(id: indiceLivro,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
                                        autor: entradaAutor,
                                        editora: entradaEditora,
                                        idioma: (Idioma)entradaIdioma,
                                        descricao: entradaDescricao,
										ano: entradaAno);
										
			repositorio.Atualiza(indiceLivro,atualizaLivro);
		}

        private static void ExcluirLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());
			repositorio.Exclui(indiceLivro);
		}

        private static void VisualizarLivro()
		{
			Console.Write("Digite o id do livro: ");
			int indiceLivro = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceLivro);

			Console.WriteLine(serie);
		}

    }
}