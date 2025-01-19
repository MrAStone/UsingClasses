namespace UsingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass("Hello", 42);
            demo.Print();
            Console.WriteLine(demo.GetNumber());
            
        }
    }
}
