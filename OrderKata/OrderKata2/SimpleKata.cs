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

    public class SimpleKata
    {
        public string CurrentGreeting = "Hello";

        public string Greeting(string name)
        {
            if (Modes.GetMode() == Mode.Mode1)
            {
                return CurrentGreeting;
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
