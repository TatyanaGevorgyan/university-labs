using System;
using System.Collections;
class Program
{  
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List<Movie> movies = new();
        for(int i = 0; i< count; i++)
        {
            Console.Write("Number ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Title ");
            string title = Console.ReadLine();

            Console.Write("Year ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Genre (1-Action, 2-Comedy, 3-Drama, 4-SciFi, 5-Horror): ");
            Genre genre = (Genre)int.Parse(Console.ReadLine());

            Console.Write("Views ");
            int views = int.Parse(Console.ReadLine());

            Console.Write("Likes ");
            int likes = int.Parse(Console.ReadLine());

            try
            {   
                Movie newMovie = new Movie(number, title, year, genre, views, likes);
                movies.Add(newMovie);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: try again");
                i--; 
            }
            
        }
        foreach(var movie in movies)
        {
            Console.WriteLine(movie.ToString());
        }

    }
}

