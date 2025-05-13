using System.Collections.Generic;

namespace chatbottwo
{
    public class Key_word
    {
        // Dictionary storing cybersecurity-related keywords and corresponding responses
        private Dictionary<string, string> keywordResponses;

        // Constructor initializes the keyword response dictionary
        public Key_word()
        {
            keywordResponses = new Dictionary<string, string>
            {
                { "password", "Make sure to use strong, unique passwords for each account." },
                { "scam", "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations." },
                { "privacy", "Review your security settings regularly and limit personal information sharing online." }
            };
        }

        // Searches user input for predefined keywords and returns a relevant cybersecurity tip
        public string GetResponse(string userInput)
        {
            // Convert user input to lowercase for case-insensitive matching
            string lowerInput = userInput.ToLower();

            // Iterate through keywords to check if any match the user input
            foreach (var keyword in keywordResponses.Keys)
            {
                if (lowerInput.Contains(keyword))
                {
                    return keywordResponses[keyword]; // Return the corresponding response
                }
            }

            return string.Empty; // Return an empty string if no keyword matches
        }
    }
}