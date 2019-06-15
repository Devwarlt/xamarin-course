public class App {
    public static void Main (string[args]) {
        Console.WriteLine ("Tell your age:");

        if (int.TryParse (Console.ReadLine (), out int age))
            Console.WriteLine ($"Your age is {age}.");
        else
            Console.WriteLine ("Age is invalid.");

        Console.WriteLine ("Press any key to exit...");
        Console.ReadLine ();
    }
}