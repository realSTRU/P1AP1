using Microsoft.EntityFrameworkCore;


public class Contexto: DbContext
{


    public DbSet<Books> Books { get; set; }

    public Contexto(DbContextOptions<Contexto> options): base(options)
    {
        
    }
}