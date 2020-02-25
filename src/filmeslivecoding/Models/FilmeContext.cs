using Microsoft.EntityFrameworkCore;

namespace filmeslivecoding.Models

{
    public class  FilmeContext : DbContext
  
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
        :base (options)
        {

        }

        public DbSet<Filme> Filmes {get; set;}

    }
    
}


