namespace LeetCodeConsole.Solutions.SQL
{
    public class RecyclableAndLowFatProducts
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════════════════");
            Console.WriteLine("  SQL Problem: Recyclable and Low Fat Products");
            Console.WriteLine("═══════════════════════════════════════════════════════════\n");

            Console.WriteLine("Table: Products");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| product_id  | int     |");
            Console.WriteLine("| low_fats    | enum    |");
            Console.WriteLine("| recyclable  | enum    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("product_id is the primary key for this table.");
            Console.WriteLine("low_fats is an ENUM of type ('Y', 'N')");
            Console.WriteLine("recyclable is an ENUM of type ('Y', 'N')\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to find the ids of products that are both");
            Console.WriteLine("low fat and recyclable.\n");

            Console.WriteLine("EXAMPLE:");
            Console.WriteLine("Input:");
            Console.WriteLine("+-------------+----------+------------+");
            Console.WriteLine("| product_id  | low_fats | recyclable |");
            Console.WriteLine("+-------------+----------+------------+");
            Console.WriteLine("| 0           | Y        | N          |");
            Console.WriteLine("| 1           | Y        | Y          |");
            Console.WriteLine("| 2           | N        | Y          |");
            Console.WriteLine("| 3           | Y        | Y          |");
            Console.WriteLine("| 4           | N        | N          |");
            Console.WriteLine("+-------------+----------+------------+\n");

            Console.WriteLine("Output:");
            Console.WriteLine("+-------------+");
            Console.WriteLine("| product_id  |");
            Console.WriteLine("+-------------+");
            Console.WriteLine("| 1           |");
            Console.WriteLine("| 3           |");
            Console.WriteLine("+-------------+\n");

            Console.WriteLine("Explanation: Only products 1 and 3 are both low fat and recyclable.\n");

            Console.WriteLine("─────────────────────────────────────────────────────────────");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("─────────────────────────────────────────────────────────────\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELECT product_id FROM Products");
            Console.WriteLine("WHERE low_fats = 'Y' AND recyclable = 'Y'");
            Console.ResetColor();

            Console.WriteLine("\n─────────────────────────────────────────────────────────────");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("─────────────────────────────────────────────────────────────");
            Console.WriteLine("Time Complexity: O(n) - where n is the number of rows");
            Console.WriteLine("Space Complexity: O(1) - only filtering, no additional space\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
