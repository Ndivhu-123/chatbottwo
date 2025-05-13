using System.Collections.Generic;
using System;


namespace chatbottwo
{
    public class random_response
    {
        public random_response() { }


        // List containing various cybersecurity tips for different security aspects
        private List<string> cybersecurityTips = new List<string>
        {
            // Phishing Protection
            "Be cautious of emails asking for personal information.",
            "Avoid clicking unknown links—always verify the sender first.",
            "Never provide your password or banking details via email or phone.",
            
            // Password Security
            "Use strong passwords that include uppercase, lowercase, numbers, and special characters.",
            "Never reuse passwords across multiple accounts.",
            "Consider using a password manager to store and generate secure passwords.",
            
            // Secure Browsing
            "Always check for HTTPS in a website’s URL to ensure a secure connection.",
            "Enable two-factor authentication (2FA) for additional account security.",
            "Regularly clear cookies and cache to remove tracking data.",
            
            // Device & Network Security
            "Keep your operating system and applications updated to patch vulnerabilities.",
            "Use a VPN when browsing on public Wi-Fi to protect your data.",
            "Disable Bluetooth and Wi-Fi when not in use to prevent unauthorized access.",
            
            // Social Engineering Awareness
            "Verify the sender before responding to unexpected requests for information.",
            "Avoid oversharing personal details on social media platforms.",
            "Cybercriminals often impersonate trusted companies—double-check official sources before interacting."
        };

        // Method to retrieve a random cybersecurity tip
        public string GetRandomTip()
        {
            Random random = new Random();
            int index = random.Next(cybersecurityTips.Count);
            return cybersecurityTips[index];
        }
    }
}
