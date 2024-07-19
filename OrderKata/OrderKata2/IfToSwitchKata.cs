namespace OrderKata2
{
    internal class IfToSwitchKata
    {
        public static string Greeting()
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
