using System.Security.Claims;

namespace ConsoleApp2
{
    public class Program
    {
        static void ShowMilionerText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string metin = @"
       /$$      /$$  /$$$$$$  /$$         /$$$$$$   /$$   /$$  /$$$$$$$$  /$$$$$$$       
      | $$$    /$$$ |_  $$_/ | $$        /$$__  $$ | $$$ | $$ | $$_____/ | $$__  $$      
      | $$$$  /$$$$   | $$   | $$       | $$  \ $$ | $$$$| $$ | $$       | $$  \ $$      
      | $$ $$/$$ $$   | $$   | $$       | $$  | $$ | $$ $$ $$ | $$$$$    | $$$$$$$/      
      | $$  $$$| $$   | $$   | $$       | $$  | $$ | $$  $$$$ | $$__/    | $$__  $$      
      | $$\  $ | $$   | $$   | $$       | $$  | $$ | $$\  $$$ | $$       | $$  \ $$      
      | $$ \/  | $$  /$$$$$$ | $$$$$$$$ |  $$$$$$/ | $$ \  $$ | $$$$$$$$ | $$  | $$      
      |__/     |__/ |______/ |________/  \______/  |__/  \__/ |________/ |__/  |__/
           




    ";

            Console.WriteLine(metin);
        }


        static void Main(string[] args)
        {
            int CorrectScore = 0;
            int InCorrectScore = 0;
            ShowMilionerText();
            string[] questions = {
            "What is the capital of the United States?\nA) Washington DC\nB) New York\nC) Los Angeles\nD) Miami",
            "What is the capital of Turkey?\nA) Istanbul \nB) Ankara\nC) İzmir\nD) Antalya",
            "What is the capital of France?\nA) Marsilya \nB) Lyon\nC) Paris\nD) Nice",
            "What is the capital of Germany?\nA) Münih \nB) Berlin\nC) Hamburg\nD) Frankfurt",
            "What is the capital of the United Kingdom?\nA) Glasgow\nB) Manchester\nC) Birmingham\nD) Londra ",
            "What is the capital of Japan?\nA) Osaka \nB) Tokyo \nC) Kyoto\nD) Yokohama",
            "What is the capital of China?\nA) Pekin\nB) Şanghay\nC) Guangzhou\nD) Shenzhen",
            "What is the capital of Italy?\nA) Napoli \nB) Milano\nC) Roma \nD) Venedik",
            "What is the capital of Russia?\nA) Moskova\nB) Sankt Petersburg\nC) Novosibirsk\nD) Ekaterinburg",
            "What is the capital of Egypt?\nA) Giza \nB) İskenderiye\nC) Kahire \nD) Şarm El-Şeyh"
        };
            string[] answers = {
                "A",
                "B",
                "C",
                "B",
                "D",
                "B ",
                "A",
                "C",
                "A",
                "C"

            };
            
            
            for (int i = 0; i < questions.Length; i++)
            {
                Console.Clear();
                ShowMilionerText();
                Console.WriteLine($"Correct Answer {CorrectScore}   \nIn Correct Answer {InCorrectScore}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ANSWER THE QUESTION \n");
                Console.WriteLine(questions[i]);
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("YOUR ANSWER  ");
                string a = Console.ReadLine();

                if (a == answers[i])
                {
                    CorrectScore+=1;
                }
                else { InCorrectScore+=1; }
            }
            Console.Clear();
            Console.WriteLine("END");
            Console.ResetColor();
        }

    }
}
