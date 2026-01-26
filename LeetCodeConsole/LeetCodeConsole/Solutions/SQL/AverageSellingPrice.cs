namespace LeetCodeConsole.Solutions.SQL
{
    public class AverageSellingPrice
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Average Selling Price");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Prices");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("| Column Name   | Type    |");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("| product_id    | int     |");
            Console.WriteLine("| start_date    | date    |");
            Console.WriteLine("| end_date      | date    |");
            Console.WriteLine("| price         | int     |");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("(product_id, start_date, end_date) is the primary key for this table.");
            Console.WriteLine("Each row indicates the price of product_id in the period from start_date to end_date.");
            Console.WriteLine("For each product_id there will be no two overlapping periods.\n");

            Console.WriteLine("Table: UnitsSold");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("| Column Name   | Type    |");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("| product_id    | int     |");
            Console.WriteLine("| purchase_date | date    |");
            Console.WriteLine("| units         | int     |");
            Console.WriteLine("+---------------+---------+");
            Console.WriteLine("This table may contain duplicate rows.");
            Console.WriteLine("Each row indicates the date, units, and product_id of each product sold.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to find the average selling price for each product.");
            Console.WriteLine("average_price should be rounded to 2 decimal places.");
            Console.WriteLine("If a product does not have any sold units, its average selling price is assumed to be 0.");
            Console.WriteLine("Return the result table in any order.\n");

            Console.WriteLine("EXAMPLE:");
            Console.WriteLine("Input:");
            Console.WriteLine("Prices table:");
            Console.WriteLine("+------------+------------+------------+--------+");
            Console.WriteLine("| product_id | start_date | end_date   | price  |");
            Console.WriteLine("+------------+------------+------------+--------+");
            Console.WriteLine("| 1          | 2019-02-17 | 2019-02-28 | 5      |");
            Console.WriteLine("| 1          | 2019-03-01 | 2019-03-22 | 20     |");
            Console.WriteLine("| 2          | 2019-02-01 | 2019-02-20 | 15     |");
            Console.WriteLine("| 2          | 2019-02-21 | 2019-03-31 | 30     |");
            Console.WriteLine("+------------+------------+------------+--------+\n");

            Console.WriteLine("UnitsSold table:");
            Console.WriteLine("+------------+---------------+-------+");
            Console.WriteLine("| product_id | purchase_date | units |");
            Console.WriteLine("+------------+---------------+-------+");
            Console.WriteLine("| 1          | 2019-02-25    | 100   |");
            Console.WriteLine("| 1          | 2019-03-01    | 15    |");
            Console.WriteLine("| 2          | 2019-02-10    | 200   |");
            Console.WriteLine("| 2          | 2019-03-22    | 30    |");
            Console.WriteLine("+------------+---------------+-------+\n");

            Console.WriteLine("Output:");
            Console.WriteLine("+------------+---------------+");
            Console.WriteLine("| product_id | average_price |");
            Console.WriteLine("+------------+---------------+");
            Console.WriteLine("| 1          | 6.96          |");
            Console.WriteLine("| 2          | 16.96         |");
            Console.WriteLine("+------------+---------------+\n");

            Console.WriteLine("Explanation:");
            Console.WriteLine("Average selling price = Total Price of Product / Number of products sold.");
            Console.WriteLine("Average selling price for product 1 = ((100 * 5) + (15 * 20)) / 115 = 6.96");
            Console.WriteLine("Average selling price for product 2 = ((200 * 15) + (30 * 30)) / 230 = 16.96\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELECT P.product_id,");
            Console.WriteLine("       ISNULL(ROUND((SUM(P.price * US.units) * 1.0 / SUM(US.units)), 2), 0)");
            Console.WriteLine("       AS average_price");
            Console.WriteLine("FROM Prices P");
            Console.WriteLine("LEFT JOIN UnitsSold US");
            Console.WriteLine("ON P.product_id = US.product_id");
            Console.WriteLine("   AND US.purchase_date BETWEEN P.start_date AND P.end_date");
            Console.WriteLine("GROUP BY P.product_id");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use LEFT JOIN to include products even without sales");
            Console.WriteLine("2. Join condition matches product_id AND purchase_date within price period");
            Console.WriteLine("3. Calculate weighted average: SUM(price * units) / SUM(units)");
            Console.WriteLine("4. Use ISNULL to return 0 for products with no sales");
            Console.WriteLine("5. ROUND to 2 decimal places as required\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n * m) - where n = prices rows, m = units sold rows");
            Console.WriteLine("Space Complexity: O(p) - where p = number of unique products\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
