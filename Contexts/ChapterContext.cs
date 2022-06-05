using Chapter1000ton.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter1000ton.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {
        }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {
        }

        // Vamos utilizar esse metodo para configurar o banco de dados
        protected override void

    OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = MILTON\\SQLEXPRESS; Initial catalog=Chapter; Integrated Security=true");
            }
        }

        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }
    }
}
