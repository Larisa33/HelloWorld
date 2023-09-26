using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            int age = ReadNumberFrmKeyboard("Please enter your age: ");
            Console.WriteLine("Hello, " + name + ", your age is: " + age);

            int year = ReadNumberFrmKeyboard("Please enter current year: ");
            Console.WriteLine("current year is" + year);


            static int ReadNumberFrmKeyboard(string eticheta) 
            {
                bool canConvert = false;
                while(!canConvert)
                {
                    Console.Write(eticheta);
                    string text = Console.ReadLine();

                    canConvert = int.TryParse(text, out int result);


                    if (canConvert)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("The text '" + text + "' dosen't represent a number.");
                    }

                }

                return 0;

            }

        }
    }
}