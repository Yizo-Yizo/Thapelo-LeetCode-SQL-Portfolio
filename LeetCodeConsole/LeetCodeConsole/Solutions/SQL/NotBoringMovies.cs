namespace LeetCodeConsole.Solutions.SQL
{
    public class NotBoringMovies
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Not Boring Movies");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Cinema");
            Console.WriteLine("+----------------+----------+");
            Console.WriteLine("| Column Name    | Type     |");
            Console.WriteLine("+----------------+----------+");
            Console.WriteLine("| id             | int      |");
            Console.WriteLine("| movie          | varchar  |");
            Console.WriteLine("| description    | varchar  |");
            Console.WriteLine("| rating         | float    |");
            Console.WriteLine("+----------------+----------+");
            Console.WriteLine("id is the primary key (column with unique values) for this table.");
            Console.WriteLine("Each row contains information about the name of a movie, its genre, and its rating.");
            Console.WriteLine("rating is a 2 decimal places float in the range [0, 10]\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to report the movies with an odd-numbered ID");
            Console.WriteLine("and a description that is not \"boring\".");
            Console.WriteLine("Return the result table ordered by rating in descending order.\n");

            Console.WriteLine("EXAMPLE:");
            Console.WriteLine("Input:");
            Console.WriteLine("Cinema table:");
            Console.WriteLine("+----+------------+-------------+--------+");
            Console.WriteLine("| id | movie      | description | rating |");
            Console.WriteLine("+----+------------+-------------+--------+");
            Console.WriteLine("| 1  | War        | great 3D    | 8.9    |");
            Console.WriteLine("| 2  | Science    | fiction     | 8.5    |");
            Console.WriteLine("| 3  | irish      | boring      | 6.2    |");
            Console.WriteLine("| 4  | Ice song   | Fantacy     | 8.6    |");
            Console.WriteLine("| 5  | House card | Interesting | 9.1    |");
            Console.WriteLine("+----+------------+-------------+--------+\n");

            Console.WriteLine("Output:");
            Console.WriteLine("+----+------------+-------------+--------+");
            Console.WriteLine("| id | movie      | description | rating |");
            Console.WriteLine("+----+------------+-------------+--------+");
            Console.WriteLine("| 5  | House card | Interesting | 9.1    |");
            Console.WriteLine("| 1  | War        | great 3D    | 8.9    |");
            Console.WriteLine("+----+------------+-------------+--------+\n");

            Console.WriteLine("Explanation:");
            Console.WriteLine("We have three movies with odd-numbered IDs: 1, 3, and 5.");
            Console.WriteLine("The movie with ID = 3 is boring so we do not include it in the answer.\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELECT * FROM Cinema");
            Console.WriteLine("WHERE id % 2 = 1 AND description <> 'boring'");
            Console.WriteLine("ORDER BY rating DESC");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use WHERE clause to filter odd-numbered IDs: id % 2 = 1");
            Console.WriteLine("2. Exclude movies with 'boring' description: description <> 'boring'");
            Console.WriteLine("3. Order by rating in descending order to show highest rated first");
            Console.WriteLine("4. SELECT * returns all columns from the Cinema table\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - where n = number of movies (due to sorting)");
            Console.WriteLine("Space Complexity: O(k) - where k = number of qualifying movies\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
