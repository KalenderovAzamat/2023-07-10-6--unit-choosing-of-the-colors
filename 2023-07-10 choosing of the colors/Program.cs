using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your fav color");
        Console.WriteLine("Your can choose one of these: ");
        Console.WriteLine("- blue");
        Console.WriteLine("- green");
        Console.WriteLine("- cyan");
        var color = Console.ReadLine();

        if (color == "blue")
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }//end if_1
        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
        }//end else_if_2
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
        }//end else

    }//end public
}//end class