using System.ComponentModel.DataAnnotations;


public class Books
{

    [Key]
    public int BookID { get; set; }
    
    [Required(ErrorMessage = "Campo no lleno-ingrese un titulo")]
    public string Titulo { get; set; }

    [Required(ErrorMessage ="Ingrese un precio!")]
    public double Precio { get; set; }
}