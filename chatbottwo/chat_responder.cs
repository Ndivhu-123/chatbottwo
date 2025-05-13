

using chatbottwo;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Chatbottwo
{
    // Main class for chatbot functionality

    public class chat_responder
    {
        public chat_responder() { }

        private string username = string.Empty;
        private string userQuery = string.Empty;
        private ArrayList replies = new ArrayList();

        // Sentiment analysis is now integrated within this class

        private Dictionary<string, string> sentimentResponses = new Dictionary<string, string>
{
    { "worried", "I understand your concern. Staying informed helps against online scams!" },
    { "confused", "No worries, cybersecurity can be complex. Let me break it down for you!" },
    { "nervous", "I get that! The online world can be scary, but knowledge is power." },
    { "overwhelmed", "Cybersecurity has many layers, but I’m here to guide you step by step!" },
    { "anxious", "It's completely normal to feel anxious about online threats. Staying proactive will keep you safe!" },
    { "excited", "That’s great energy! Learning more about cybersecurity makes your online world safer." },
    { "curious", "Curiosity is key! The more you know, the better prepared you’ll be." },
    { "motivated", "I love that spirit! Strengthening your cybersecurity skills will really pay off." },
    { "frustrated", "I understand how frustrating cybersecurity challenges can be. Let’s work through them together!" },
    { "stressed", "Cybersecurity can seem overwhelming, but small steps make a big difference. I can help!" }
};

        private Key_word keywordRecognition = new Key_word();

        public void StartConversation()
        {
            StoreReplies();


            // Chatbot asks for the user's name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Chatbot: Hey there! What’s your first name?");
            Console.ResetColor();

            // User enters their name in magenta
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("You: ");
            username = Console.ReadLine();
            Console.ResetColor();

            // Chatbot greets the user
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Chatbot: Hey {username}, how can I assist you today?");
            Console.ResetColor();

            do
            {
                // User enters query in magenta
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(username + ": ");
                userQuery = Console.ReadLine();
                Console.ResetColor();

                if (userQuery.ToLower() != "exit")
                {
                    ProcessQuery(userQuery);
                }

            } while (userQuery.ToLower() != "exit");

            // Chatbot says goodbye
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Ensure string interpolation is used properly
            Console.WriteLine($"Chatbot: Bye for now! Don't hesitate to reach out again, {username}! Have a great day ahead!");

            Console.ForegroundColor = ConsoleColor.Magenta;

            // Properly formatted separator for visual effect
            Console.WriteLine("............................................................................................");

            Console.ResetColor(); // Reset colors to default

        }

        private void StoreReplies()
        {
            replies.Add("Strong passwords should include uppercase letters, lowercase letters, numbers, and special characters.");
            replies.Add("Phishing attempts often use fake links and urgent language. Be cautious.");
            replies.Add("Always use multi-factor authentication for sensitive accounts.");
            replies.Add("Public Wi-Fi can expose you to hackers. Use a VPN when possible.");
        }

        private void ProcessQuery(string query)
        {
            bool answered = false;

            foreach (string reply in replies)
            {
                if (query.ToLower().Contains("password") && reply.ToLower().Contains("password"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Chatbot: " + reply);
                    Console.ResetColor();
                    answered = true;
                    break;
                }
                else if (query.ToLower().Contains("phishing") && reply.ToLower().Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Chatbot: " + reply);
                    Console.ResetColor();
                    answered = true;
                    break;
                }
            }

            // Check sentiment for an emotional response
            foreach (var sentiment in sentimentResponses.Keys)
            {
                if (query.ToLower().Contains(sentiment))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Chatbot: " + sentimentResponses[sentiment]);
                    Console.ResetColor();
                    answered = true;
                }
            }

            // Check for keyword recognition
            string keywordResponse = keywordRecognition.GetResponse(query);
            if (!string.IsNullOrEmpty(keywordResponse))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Chatbot: " + keywordResponse);
                Console.ResetColor();
                answered = true;
            }

            if (!answered)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Chatbot: I'm not sure I understand. Can you rephrase?");
                Console.ResetColor();
            }
        }
    }
}
