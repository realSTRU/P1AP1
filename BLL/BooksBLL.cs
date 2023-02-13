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


    public bool Modificar(Books book)
    {
        _contexto.Entry(book).State = EntityState.Modified;

        bool Modificado = _contexto.SaveChanges() > 0;

        _contexto.Entry(book).State = EntityState.Detached;

        return Modificado; 
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

    




    


    


}