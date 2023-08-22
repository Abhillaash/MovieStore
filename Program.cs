using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore2.Controller;
using MovieLibraries.Service;
using MovieLibraries.Model;
using MovieLibraries.MovieExceptions;

namespace MovieStore2
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieController movieController = new MovieController();


            MovieController.Start();
        }
    }
}
