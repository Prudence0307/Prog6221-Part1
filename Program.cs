using System;
using System.Media;
using System.Speech.Synthesis;
using System.Threading;

// Interface
interface IChatbot
{
    void StartChat();
    string GetResponse(string userInput);
}

// Base class (Encapsulation)
class ChatbotBase
{
    protected string userName;

    public void SetUserName(string name)
    {
        userName = name;
    }

    public string GetUserName()
    {
        return userName;
    }
}

// Derived class (Inheritance)
class CyberBot : ChatbotBase, IChatbot
{
    private SpeechSynthesizer speech = new SpeechSynthesizer();

    public CyberBot()
    {
        speech.Rate = 0;
        speech.Volume = 100;
    }

    // ASCII Logo Method
    private void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
   _____       _               ____        _   
  / ____|     | |             |  _ \      | |  
 | |     _   _| |__   ___ _ __| |_) | ___ | |_ 
 | |    | | | | '_ \ / _ \ '__|  _ < / _ \| __|
 | |____| |_| | |_) |  __/ |  | |_) | (_) | |_ 
  \_____|\__,_|_.__/ \___|_|  |____/ \___/ \__|

   CYBERSECURITY AWARENESS BOT
");
        Console.ResetColor();
    }

    // ✅ NEW: Typing effect method
    private void TypeText(string message, int delay = 20)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    // Output with typing + speech
    private void PrintBot(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Bot: ");

        TypeText(message); // ✅ typing effect

        Console.ResetColor();

        speech.SpeakAsync(message); // non-blocking speech
    }

    private void PrintSystem(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void StartChat()
    {
        ShowLogo();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("=== Cybersecurity Awareness Chatbot ===");
        Console.ResetColor();

        // Name input validation
        while (true)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                SetUserName(name);
                break;
            }
            else
            {
                PrintSystem("Invalid input. Name cannot be empty.");
            }
        }

        PrintBot($"Hello {GetUserName()}! I'm your cybersecurity assistant.");
        PrintSystem("Type 'exit' to quit.\n");

        // Main loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(GetUserName() + ": ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                PrintSystem("Please enter a valid question.");
                continue;
            }

            if (input == "exit")
            {
                PrintBot($"Goodbye {GetUserName()}! Stay safe online.");
                break;
            }

            string response = GetResponse(input);
            PrintBot(response);
        }
    }
    public string GetResponse(string userInput)
    {
        if (userInput.Contains("how are you"))
            return $"I'm functioning perfectly, {GetUserName()}!How can I help you stay safe online?\n";

        if (userInput.Contains("purpose"))
            return "My purpose is to educate users about cybersecurity and help you stay safe online.\n";

        if (userInput.Contains("what can i ask"))
            return "You can ask me about password safety, phishing, safe browsing, malware, and Wi-Fi security.\n";

        if (userInput.Contains("password"))
            return "Use strong passwords with a mix of letters, numbers, and symbols. Avoid using personal information.\n";

        if (userInput.Contains("phishing"))
            return "Phishing is when attackers trick you into revealing sensitive information. Always verify suspicious emails or links.\n";

        if (userInput.Contains("safe browsing"))
            return "Only visit secure websites (https), avoid clicking unknown links, and keep your browser updated.\n";

        if (userInput.Contains("malware"))
            return "Malware is harmful software. Install antivirus software and avoid downloading from untrusted sources.\n";

        if (userInput.Contains("wifi"))
            return "Avoid using public Wi-Fi for sensitive transactions unless you use a VPN.\n";

        return "I didn't understand. Try cybersecurity topics.";
    }

    class Program
{
    static void Main(string[] args)
    {
        // Play startup sound
        try
        {
            string audioPath = "../../../Greeting.wav";
            using (var player = new SoundPlayer(audioPath))
            {
                player.PlaySync();
            }
        }
        catch
        {
            Console.WriteLine("Startup sound not found.");
        }

        CyberBot bot = new CyberBot();
        bot.StartChat();
    }
}

}
