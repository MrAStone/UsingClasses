namespace UsingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass("Hello", 42);
            demo.Print();
            Console.WriteLine(demo.GetNumber());

            InsideCode inside = new InsideCode("World", 24);
            inside.Print();
            Console.WriteLine(inside.GetNumber());

        }
    }
    class InsideCode
    {
        string thing;
        int number;
        public InsideCode(string thing, int number)
        {
            this.thing = thing;
            this.number = number;
        }
        public void Print()
        {
            Console.WriteLine($"Thing: {thing}, Number: {number}");
        }
        public int GetNumber()
        {
            return number;
        }
    }
}
