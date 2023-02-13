using System.ComponentModel.DataAnnotations;


public class Books
{

    [Key]
    public int BookID { get; set; }
    
    public string? Titulo { get; set; }

    public double Precio { get; set; }
}