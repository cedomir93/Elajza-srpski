using System;

namespace Elajza_srpski
{
    class Program
    {
        static void Main(string[] args)
        {
            ElizaChat eliza = new ElizaChat();

            Console.WriteLine("Elajza: Zdravo! Ja se zovem Elajza! Kako mogu da ti pomognem?");
            string userInput;
            do
            {
                Console.Write("Ti: ");
                userInput = Console.ReadLine();
                string response = eliza.Respond(userInput);
                Console.WriteLine("Elajza: " + response);

            } while (!userInput.Equals("kraj", StringComparison.OrdinalIgnoreCase));
        }
    }
}
