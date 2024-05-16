
namespace Task02
{
    static class ColorPrinter
    {
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть текст для виводу:");
            string inputText = Console.ReadLine();

            Console.WriteLine("Варіанти кольорів:");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. DarkBlue");
            Console.WriteLine("3. DarkGreen");
            Console.WriteLine("4. DarkCyan");
            Console.WriteLine("5. DarkRed");
            Console.WriteLine("6. DarkMagenta");
            Console.WriteLine("7. DarkYellow");
            Console.WriteLine("8. Gray");
            Console.WriteLine("9. DarkGray");
            Console.WriteLine("10. Blue");
            Console.WriteLine("11. Green");
            Console.WriteLine("12. Cyan");
            Console.WriteLine("13. Red");
            Console.WriteLine("14. Magenta");
            Console.WriteLine("15. Yellow");
            Console.WriteLine("16. White");
            Console.Write("Введіть номер кольору: ");

            if (int.TryParse(Console.ReadLine(), out int colorChoice))
            {
                if (colorChoice >= 1 && colorChoice <= 16)
                {
                    ConsoleColor chosenColor = (ConsoleColor)(colorChoice - 1);
                    ColorPrinter.Print(inputText, chosenColor);
                } 
                else
                {
                    Console.WriteLine("Помилковий вибір кольору");
                }
            }
            else
            {
                Console.WriteLine("Число не число, як так?");
            }

            Console.WriteLine("Нажміть ентер для форматування диску С...");
            Console.ReadKey();
        }
    }


}
