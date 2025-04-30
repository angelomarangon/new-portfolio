using System.ComponentModel.DataAnnotations;


namespace Portfolio.Models;

public class ContactoViewModel
{
    [Required]
    public string Nombre { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Mensaje { get; set; }
}