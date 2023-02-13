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

    


    


    


}