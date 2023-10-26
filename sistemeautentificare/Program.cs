namespace sistemeautentificare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usernamebun = "beta";
            const string parolabuna = "787";

            bool corect = false;

            while (!corect)
            {
                Console.WriteLine("Introduceti username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Introduceti parola: ");
                string parola = Console.ReadLine();

                if (username == usernamebun && parola == parolabuna)
                {
                    Console.WriteLine("Bine ai venit, " + usernamebun);
                    corect = true;
                }
                else
                {
                    Console.WriteLine("Incorect, incercati din nou");
                }
            }
        }
    }
}