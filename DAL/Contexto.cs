using Microsoft.EntityFrameworkCore;


public class Contexto: DbContext
{


    public DbSet<Books> Books { get; set; }

    public Contexto(DbContextOptions<Contexto> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Books>().HasData(

            new Books{
                BookID = 1,
                Titulo = "Berserk Vol.1",
                Precio = 2000,
                Emison = new DateOnly(2000,10,1)
            },
            new Books{
                BookID = 2,
                Titulo = "Berserk Vol.2",
                Precio = 3000,
                Emison = new DateOnly(2001,10,1)
            },
            new Books{
                BookID = 3,
                Titulo = "Berserk Vol.3",
                Precio = 4000,
                Emison = new DateOnly(2002,10,1)
            },
            new Books{
                BookID = 4,
                Titulo = "Berserk Vol.4",
                Precio = 5000,
                Emison = new DateOnly(2003,10,1)
            },
            new Books{
                BookID = 5,
                Titulo = "Berserk Vol.5",
                Precio = 6000,
                Emison = new DateOnly(2004,10,1)
            },
            new Books{
                BookID = 6,
                Titulo = "Berserk Vol.6",
                Precio = 7000,
                Emison = new DateOnly(2005,10,1)
            },
            new Books{
                BookID = 7,
                Titulo = "Berserk Vol.7",
                Precio = 8000,
                Emison = new DateOnly(2006,10,1)
            },
            new Books{
                BookID = 8,
                Titulo = "Berserk Vol.8",
                Precio = 9000,
                Emison = new DateOnly(2007,10,1)
            },
            new Books{
                BookID = 9,
                Titulo = "Berserk Vol.9",
                Precio = 10000,
                Emison = new DateOnly(2008,10,1)
            },
            new Books{
                BookID = 10,
                Titulo = "Berserk Vol.10",
                Precio = 11000,
                Emison = new DateOnly(2009,10,1)
            },
            new Books{
                BookID = 11,
                Titulo = "Berserk Vol.11",
                Precio = 12000,
                Emison = new DateOnly(2022,10,1)
            }



        );
    }
}