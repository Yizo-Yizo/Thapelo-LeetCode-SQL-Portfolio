namespace LeetCodeConsole.Solutions.SQL
{
    public class NthHighestSalary
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Nth Highest Salary");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Employee");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| Column Name | Type |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| id          | int  |");
            Console.WriteLine("| salary      | int  |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("id is the primary key for this table.");
            Console.WriteLine("Each row contains information about the salary of an employee.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to find the nth highest distinct salary from the Employee table.");
            Console.WriteLine("If there are less than n distinct salaries, return null.\n");

            Console.WriteLine("EXAMPLE 1:");
            Console.WriteLine("Input:");
            Console.WriteLine("Employee table:");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| id | salary |");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| 1  | 100    |");
            Console.WriteLine("| 2  | 200    |");
            Console.WriteLine("| 3  | 300    |");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("n = 2");
            Console.WriteLine("\nOutput:");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| getNthHighestSalary(2) |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| 200                    |");
            Console.WriteLine("+------------------------+\n");

            Console.WriteLine("EXAMPLE 2:");
            Console.WriteLine("Input:");
            Console.WriteLine("Employee table:");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| id | salary |");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("| 1  | 100    |");
            Console.WriteLine("+----+--------+");
            Console.WriteLine("n = 2");
            Console.WriteLine("\nOutput:");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| getNthHighestSalary(2) |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| null                   |");
            Console.WriteLine("+------------------------+\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS");
            Console.WriteLine("BEGIN");
            Console.WriteLine("    RETURN (");
            Console.WriteLine("        SELECT DISTINCT salary");
            Console.WriteLine("        FROM Employee");
            Console.WriteLine("        ORDER BY salary DESC");
            Console.WriteLine("        OFFSET @N-1 ROWS");
            Console.WriteLine("        FETCH NEXT 1 ROWS ONLY");
            Console.WriteLine("    );");
            Console.WriteLine("END");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use DISTINCT to eliminate duplicate salaries");
            Console.WriteLine("2. ORDER BY salary DESC to rank salaries from highest to lowest");
            Console.WriteLine("3. OFFSET @N-1 ROWS skips the top (N-1) salaries");
            Console.WriteLine("4. FETCH NEXT 1 ROWS ONLY retrieves the Nth highest salary");
            Console.WriteLine("5. Returns NULL automatically if fewer than N distinct salaries exist\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - due to sorting");
            Console.WriteLine("Space Complexity: O(n) - for the distinct salary set\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
