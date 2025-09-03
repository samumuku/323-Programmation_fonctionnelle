using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> frenchMovies = new List<Movie>() {
            new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
            new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
            new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
            new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
            new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
            new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
            };
            // Partie 1
            Func<Movie, bool> isNotComedyOrDrama = movie => movie.Genre != "Comédie" && movie.Genre != "Drame";
            frenchMovies.Where(isNotComedyOrDrama).ToList().ForEach(movie => Console.WriteLine("1. " + movie.Title));

            // Partie 2
            const double RATING_NUMBER = 7;
            Func<Movie, bool> hasRatingUnderSeven = movie => movie.Rating < RATING_NUMBER;
            frenchMovies.Where(hasRatingUnderSeven).ToList().ForEach(movie => Console.WriteLine("2. " + movie.Title));

            // Partie 3
            const int YEAR = 2000;
            Func<Movie, bool> isMovieBefore2000 = movie => movie.Year < YEAR;
            frenchMovies.Where(isMovieBefore2000).ToList().ForEach(movie => Console.WriteLine("3. " + movie.Title));

            // Partie 4
            Func<Movie, bool> hasNotFrenchLanguage = movie => !movie.LanguageOptions.Contains("Français");
            frenchMovies.Where(hasNotFrenchLanguage).ToList().ForEach(movie => Console.WriteLine("4. " + movie.Title));

            // Partie 5
            Func<Movie, bool> isNotOnNetflix = movie => !movie.StreamingPlatforms.Contains("Netflix");
            frenchMovies.Where(isNotOnNetflix).ToList().ForEach(movie => Console.WriteLine("5. " + movie.Title));
        }
    }
}
