using Microsoft.EntityFrameworkCore;

namespace catalogo.Models
{
    public class Contexto : DbContext
    {
        public DbSet<ControleCadastro> Cadastro { get; set;}
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) 
        { 
        
        }
    }
}
