namespace GreetingAppp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your total enrolled courses:");
        int courses;
        courses = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price of your favorite book:");
        double book;
        book = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Name:" + " " + name);
        Console.WriteLine("Total enrolled courses:" + " " + courses);
        Console.WriteLine("Price of my favorite book" + " " + book);
        }
    }
}