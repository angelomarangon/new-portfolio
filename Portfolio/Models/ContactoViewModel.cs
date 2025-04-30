using System.ComponentModel.DataAnnotations;


namespace Portfolio.Models;

public class ContactoViewModel
{
    [Required(ErrorMessage = "Name field is required")]
    public string Nombre { get; set; }
    
    [Required(ErrorMessage = "Email field is required")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Message field is required")]
    public string Mensaje { get; set; }
}