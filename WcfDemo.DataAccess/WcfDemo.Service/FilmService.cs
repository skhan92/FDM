using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfDemo.DataAccess;

namespace WcfDemo.Service
{
    [ServiceContract] //this acts like an access modifier for the interface. Means it can be viewed externally
    public interface IFilmService
    {
        //going to contain lots of operation contracts, so methods, which anyone can come along and use
        [OperationContract] //like an access modifier, isn't but can be thought of one. Enables running of method from outside of our program.
        List<Film> GetAllFilms();

        //public List<Film> UpdateAllFilms(); THIS METHOD CANT BE RUN EXTERNALLY, BUT IS STILL IN THE APPLICATION *ADMIN*
    }

    public class FilmService : IFilmService //CLASS MAY LOOK POINTLESS BUT IT ENABLES SOLID SO CHANGES TO THE WAY GETALLFILMS WORKS CAN BE EASILY IMPLEMENTED
    {
        FilmRepository filmRepo;

        public FilmService()
        {
            filmRepo = new FilmRepository();
        }

        public List<Film> GetAllFilms()
        {
            return filmRepo.GetAllFilms();
        }
    }
}
