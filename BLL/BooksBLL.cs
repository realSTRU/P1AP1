using Microsoft.EntityFrameworkCore;


public class BooksBLL
{


    private Contexto _contexto {get; set;}


    public BooksBLL(Contexto contexto)
    {
        this._contexto = contexto;
    }



    public bool Existe(int BookID)
    {
        return _contexto.Books.Any(o=> o.BookID == BookID);
    }

    public bool Insertar(Books book)
    {
        _contexto.Books.Add(book);

        bool insertado = _contexto.SaveChanges() > 0;

        _contexto.Entry(book).State = EntityState.Detached;

        return insertado;

    }

    public Books? Buscar(int BookID)
    {
        var buscado = _contexto.Books
        .Where(o => o.BookID == BookID)
        .AsNoTracking()
        .SingleOrDefault();

        return buscado;
    }


    public bool Modificar(Books book)
    {
        _contexto.Entry(book).State = EntityState.Modified;
    
        return _contexto.SaveChanges() > 0;

    }

    public bool Guardar(Books book)
    {
        if(!Existe(book.BookID))
        {
            return this.Insertar(book);
        }
        else
        {
            return this.Modificar(book);
        }
    }

    public bool Eliminar(Books book)
    {
        _contexto.Entry(book).State=EntityState.Deleted;

        
        _contexto.Database.ExecuteSqlRaw($"DELETE FROM Books WHERE BookID={book.BookID}; ");

        Console.WriteLine("VALOR Eliminado");

        bool Eliminado = _contexto.SaveChanges() > 0;

        _contexto.Entry(book).State=EntityState.Detached;

        
        return Eliminado;
    }


    public List<Books> GetList()
    {
        return _contexto.Books.ToList();
    }





    


    


}