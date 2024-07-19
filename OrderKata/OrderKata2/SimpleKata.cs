namespace OrderKata2
{
    public class SimpleKataRunner
    {
        public static void Run()
        {
            var kata = new SimpleKata();
            var result = kata.Greeting("hello");

            Console.WriteLine(result.Item1);
        }
    }

    internal class SimpleKata
    {
        public (string, bool) Greeting(string name)
        {
            if (Modes.GetMode() == Mode.Mode1)
            {
                return ("Hello", true);
            }
            else
            {
                return ("Goodbye", false);
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
