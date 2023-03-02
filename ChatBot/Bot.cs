using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    /// <summary>
    /// Provides methods to implement a chat bot.
    /// </summary>
    public class Bot
    {
        private static string[] randomQuestions = { "How was your day?",
            "How is the weather?", "What is your favorite food?",
            "What is your favorite color?", "Do you have any pets?"};

        private static string[] randomResponses = { "I'm not sure...",
            "I don't understand what you said.",
            "I am a computer that can talk.",
            "98% inspiration, 1% perspiration, and 2% attention to detail."};

        /// <summary>
        /// Returns a response to the user's input.
        /// </summary>
        /// <param name="input">The user's response to the computer.</param>
        /// <returns>The computer's response to the computer.</returns>
        public string Chat(string input)
        {
            int r;
            string lower = input.ToLower();
            Random rng = new Random();
            if (lower.IndexOf("hello") >= 0)
            {
                return "Hello, let's have a conversation.";
            }
            else if (lower.IndexOf("goodbye") >= 0)
            {
                return "Goodbye!";
            }
            else if (lower.IndexOf("weather") >= 0)
            {
                return "It is doing something outside...";
            }
            else if (lower.IndexOf("dog") >= 0)
            {
                return "Tell me more about your dog.";
            }
            else if (lower.IndexOf("cat") >= 0)
            {
                return "Tell me more about your cat.";
            }
            else if (lower.IndexOf("school") >= 0)
            {
                return "What is your favorite class in school?";
            }
            else if (lower.IndexOf("class") >= 0)
            {
                return "I like that class too!";
            }
            else if (lower.IndexOf("bore") >= 0)
            {
                return "Why are you bored?";
            }
            else if (lower.IndexOf("suck") >= 0)
            {
                return "No need for foul language.";
            }
            else if (lower.IndexOf("?") >= 0)
            {
                r = rng.Next(0, randomResponses.Length);
                return randomResponses[r];
            }
            r = rng.Next(0, randomQuestions.Length);
            return randomQuestions[r];
        }

        /// <summary>
        /// Returns a greeting for the chat bot.
        /// </summary>
        /// <returns>The chat bot's greeting.</returns>
        public string Greeting()
        {
            return "Hello, my name is Chatter. Let's have a conversation.";
        }
    }
}
