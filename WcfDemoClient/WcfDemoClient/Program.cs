using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfDemo.DataAccess;

namespace WcfDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmServiceClient proxy = new FilmServiceClient();

            Film[] films = proxy.GetAllFilms();

            foreach (Film film in films)
	        {
                Console.WriteLine(film.name);
	        }

            Console.ReadLine();
        }
    }
}
