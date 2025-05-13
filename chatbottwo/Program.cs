
using Chatbottwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatbottwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creating instance for class voice_greeting
            new voice_greeting() { };

            //creating an instance for class ascii_image
            new asii_image() { };

            // creating instance for chat_responder
           new chat_responder() { };

            // Creating an instance of the Key_wordn class
            new Key_word() { };

            // Creating an instance of the random_response class
           new random_response() { };

            // Creating an instance of the memory_manager class
           new memory_manager() { };

            // Display chatbot welcome message and start conversation
            Console.WriteLine("Hi! I'm CHATBOT, here to assist, chat, and explore with you. Let's get started.");
           new chat_responder().StartConversation();

        }
    }
}
