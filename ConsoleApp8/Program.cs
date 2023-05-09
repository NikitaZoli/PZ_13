// See https://aka.ms/new-console-template for more information
namespace pz_13
{
    internal class Program
    {

        static bool IsFormul(string str)
        {
            string openBrackets = "";
            string closeBrackets = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    openBrackets += str[i];
                else if (str[i] == ')')
                    closeBrackets += str[i];
                else
                    continue;
            }

            if (openBrackets.Length == closeBrackets.Length)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(IsFormul(str));
        }
    }
}
