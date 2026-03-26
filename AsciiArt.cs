namespace CybersecurityAwarenessChatbot
{
    public class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=======================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("=======================================");
            Console.WriteLine(@" 
        [###########]
        [  SECURE   ]
        [   YOUR    ]
        [   DATA    ]
        [###########]
            ");

            Console.ResetColor();
        }
    }
}