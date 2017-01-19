using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfDemo.DataAccess
{
    public interface IFilmRepository
    {
        List<Film> GetAllFilms();
    }

    public class FilmRepository : IFilmRepository
    {
        Model context;

        public FilmRepository()
        {
            context = new Model();
        }

        public List<Film> GetAllFilms()
        {
            return context.films.ToList();
        }
    }
}
