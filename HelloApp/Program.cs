
namespace HelloApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }

        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}