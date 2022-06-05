using Chapter1000ton.Contexts;
using Chapter1000ton.Models;

namespace Chapter1000ton.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id);
        }

        public void Incluir(Livro livro)
        {
            _context.Livros.Add(livro);

            _context.SaveChanges();
        }

        public void Alterar(int id, Livro livro)
        {
            Livro livroBuscado = _context.Livros.Find(id);

            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;

                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;

                livro.Disponivel = livro.Disponivel;
            }
            _context.Livros.Update(livroBuscado);

            _context.SaveChanges();

        }

        public void Deletar(int id)
        {
            Livro livro = _context.Livros.Find(id);

            _context.Livros.Remove(livro);

            _context.SaveChanges();
        }


    }
}
