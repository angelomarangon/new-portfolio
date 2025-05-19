using Portfolio.Models;

namespace Portfolio.Services;

public interface IRepositorioProyectos
{
    List<Proyecto> ObtenerProyectos();
}

public class RepositorioProyectos : IRepositorioProyectos
{
    public List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>()
        {
            new Proyecto
            {
                Titulo = "Medical Appointment Management",
                Tecnologias = ["Node", "Express", "PostgreSQL", "React", "TypeScript", "Docker", "HTML", "CSS", "Javascript",],
                Link = "https://anmamedical.vercel.app",
                ImagenURL = "/img/anmamedical-vistageneral.png"
            },
            new Proyecto
            {
                Titulo = "Your Personal Finance Assistant",
                Tecnologias = ["C#", ".NET", "PostgreSQL", "Dapper", "Azure", "Razor", "Bootstrap", "HTML", "CSS", "Javascript",],
                Link = "https://budgetmanagement-gxhpbnhha9eqcca3.westeurope-01.azurewebsites.net/",
                ImagenURL = "/img/login.png"
            },
            new Proyecto
            {
                Titulo = "Landing Page for Marketing",
                Tecnologias = ["HTML", "CSS", "Javascript", "Tailwind CSS"],
                Link = "https://webpage-angelomarangon.vercel.app/",
                ImagenURL = "/img/webpage-1.png"
            },
            new Proyecto
            {
                Titulo = "My Developer Portfolio – Multilingual",
                Tecnologias = ["HTML", "CSS", "Javascript", "Bootstrap", "C#", ".NET", "Razor"],
                Link = "https://angelomarangon.onrender.com",
                ImagenURL = "/img/portfolio.png"
            },
            new Proyecto
            {
                Titulo = "GamePage – Gaming Landing Page",
                Tecnologias = ["HTML", "CSS", "Javascript", "Tailwind CSS"],
                Link = "https://gamepage-angelomarangon.vercel.app/",
                ImagenURL = "/img/gamer-1.png"
            },
            new Proyecto
            {
                Titulo = "My First Steps as a Developer",
                Tecnologias = ["HTML", "CSS", "Javascript", "Tailwind CSS"],
                Link = "https://portfolio-angelomarangon.vercel.app/",
                ImagenURL = "/img/cv-1.png"
            }
        };
    }
}