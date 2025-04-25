using System.Reflection.Metadata.Ecma335;

namespace Portfolio.Models;

public class HomeIndexViewModel
{
    public IEnumerable<Proyecto> Proyectos { get; set; }
}