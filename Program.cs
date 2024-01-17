using RollTheDice;

internal class Program
{
    private static void Main(string[] args)
    {
        string numOfRolls = "";

        // Create new "RolledDice Object"
        RollIt ri = new RollIt();

        System.Console.WriteLine("How many times would you like to roll the dice?:");
        numOfRolls = System.Console.ReadLine();

        // Convert the string to an integer and assign it to a variable
        int rolls = int.Parse(numOfRolls);

        // Pass the parsed integer to the Roll method, and assign it to a new array
        int[] resultArray = ri.Roll(rolls);

        for (int i = 0; i < resultArray.Length; i++)
        {
            int percentage = resultArray[i] * 100 / rolls;

            System.Console.Write($"{i + 2}:");

            for (int j = 0; j < percentage; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine($" ({percentage}%)");
        }
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
