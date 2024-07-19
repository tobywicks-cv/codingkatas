namespace OrderKata2
{
    public class SimpleKataRunner
    {
        public static void Run()
        {
            var kata = new SimpleKata();
            var result = kata.Greeting("hello");

            Console.WriteLine(result);
        }
    }

    internal class SimpleKata
    {
        public string Greeting(string name)
        {
            if (Modes.GetMode() == Mode.Mode1)
            {
                return "Hello";
            }
            else
            {
                return "Goodbye";
            }
        }
    }

    public enum Mode
    {
        Mode1,
        Mode2
    }

    public class Modes
    {
        public static Mode GetMode() => Mode.Mode1;
    }
}
