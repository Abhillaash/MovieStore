using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MovieLibraries.Service;
using MovieLibraries.Model;
using MovieLibraries.MovieExceptions;
using System.Configuration;

namespace MovieStore2.Controller
{

    class MovieController
    {
        private MovieManager movieManager;
        //public static string filePath = ConfigurationManager.AppSettings["path"];
        public MovieController()
        {
            movieManager = new MovieManager();
        }
        
        public static void Start()
        {
            DisplayMenu();
        }
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("welcome to the movie libraries");
                Console.WriteLine("Click\n" +
                    "1.  Dispaly Movie\n2. for Add movies\n3. Display movie by year" +
                    "\n4. Remove movie by movie mane \n" +
                    "5. Clear All \n6. Save the data\n7. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                    MovieManager.ShowInfo();

                }
                else if (choice == 2)
                {
                    SetMoviedetails();
                }
                else if (choice == 3)
                {
                    MovieManager.DisplayMovieByYear();
                }
                else if (choice == 4)
                {
                    
                    try
                    {
                        if (MovieManager.RemoveMovieByMovieName())
                        {
                            Console.WriteLine("movie removed");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (choice == 5)
                {
                    MovieManager.ClearAllMovies();
                }
                else if (choice == 6)
                {
                    MovieManager.SaveMovie();
                }
                else if (choice == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    continue;
                }
            }
        }
        private static void SetMoviedetails()
        {
            try
            {
                if (MovieManager.AddInfo())
                {
                    Console.WriteLine("movie added");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
