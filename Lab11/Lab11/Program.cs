using Movies.Library;
using System;
using System.Collections;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList movies = SampleData();
            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine($"There are {movies.Count} movies in this list.");
            CategorySelect(movies);
        }

        private static void CategorySelect(ArrayList movies)
        {
            do
            {
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1. Animated\n2. Drama\n3. Horror\n4. Scifi");
                switch (Console.ReadLine().ToLower())
                {
                    case "animated":
                    case "1":
                        PrintMovies(movies, "animated");
                        break;
                    case "drama":
                    case "2":
                        PrintMovies(movies, "drama");
                        break;
                    case "horror":
                    case "3":
                        PrintMovies(movies, "horror");
                        break;
                    case "scifi":
                    case "4":
                        PrintMovies(movies, "scifi");
                        break;
                    default:
                        Console.WriteLine("Category not recognized.");
                        break;
                }
            } while (IsRepeating());
        }

        private static void PrintMovies(ArrayList movies, string category)
        {
            foreach (Movie movie in movies)
            {
                if (movie.Category == category)
                {
                    Console.WriteLine($"{movie.Title}");
                }
            }
        }

        private static bool IsRepeating()
        {
            while (true)
            {
                Console.Write("Continue? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static ArrayList SampleData()
        {
            return new ArrayList()
            {
                new Movie("Bee Movie", "animated"),
                new Movie("Shrek", "animated"),
                new Movie("Shrek 2", "animated"),
                new Movie("Shrek the Third", "animated"),
                new Movie("Shrek Forever After", "animated"),
                new Movie("Hot Wheels World Race: Highway 35", "animated"),
                new Movie("Spirited Away", "animated"),
                new Movie("Howl's Moving Castle", "animated"),
                new Movie("Ponyo", "animated"),
                new Movie("My Neighbor Totoro", "animated"),
                new Movie("Grave of the Fireflies", "animated"),
                new Movie("Nausicaa of the Valley of the Wind", "animated"),
                new Movie("The Room", "drama"),
                new Movie("High School Musical", "drama"),
                new Movie("High School Musical 2", "drama"),
                new Movie("High School Musical 3: Senior Year", "drama"),
                new Movie("Harry Potter and the Sorcerer's Stone", "drama"),
                new Movie("Harry Potter and the Chamber of Secrets", "drama"),
                new Movie("Harry Potter and the Prisoner of Azkaban", "drama"),
                new Movie("Harry Potter and the Goblet of Fire", "drama"),
                new Movie("Harry Potter and the Order of the Phoenix", "drama"),
                new Movie("Harry Potter and the Half-Blood Prince", "drama"),
                new Movie("Harry Potter and the Deathly Hallows - Part 1", "drama"),
                new Movie("Harry Potter and the Deathly Hallows - Part 2", "drama"),
                new Movie("Star Wars Episode I - The Phantom Menace", "scifi"),
                new Movie("Star Wars Episode II - Attack of the Clones", "scifi"),
                new Movie("Star Wars Episode III - Revenge of the Sith", "scifi"),
                new Movie("Star Wars Episode IV - A New Hope", "scifi"),
                new Movie("Star Wars Episode V - The Empire Strikes Back", "scifi"),
                new Movie("Star Wars Episode VI - Return of the Jedi", "scifi"),
                new Movie("Star Wars Episode VII - The Force Awakens", "scifi"),
                new Movie("Star Wars Episode VIII - The Last Jedi", "scifi"),
                new Movie("Rogue One: A Star Wars Story", "scifi"),
                new Movie("Solo: A Star Wars Story", "scifi"),
                new Movie("Star Trek", "scifi"),
                new Movie("Star Trek Into Darkness", "scifi"),
                new Movie("It", "horror"),
                new Movie("The Witch", "horror"),
                new Movie("Hereditary", "horror"),
                new Movie("A Quiet Place", "horror"),
                new Movie("Get Out", "horror"),
                new Movie("Split", "horror"),
                new Movie("The Conjuring", "horror"),
                new Movie("The Babadook", "horror"),
                new Movie("It Follows", "horror"),
                new Movie("The Cabin in the Woods", "horror"),
                new Movie("Oculus", "horror"),
                new Movie("The Emoji Movie", "horror")
            };
        }
    }
}
