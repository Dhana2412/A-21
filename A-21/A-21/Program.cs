
using System;
using System.Collections.Generic;
using System.Threading;

namespace KidsLearningSystem
{
    class Program
    {
        static List<string> fruits = new List<string> { "Apple", "Banana", "Cherry",  "Fig", "Grape",  "Jackfruit", "Kiwi" };
        static List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        static List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July" };
        static Dictionary<string, string> words = new Dictionary<string, string> { { "Apple", "A round fruit that is typically red or green." }, { "Banana", "A long curved fruit with a yellow skin." }, { "Cherry", "A small round fruit that is typically red or black." },  };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Learning!");

            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWords);

            daysThread.Start();
            Thread.Sleep(5000); // Wait 5 seconds before starting the next thread
            monthsThread.Start();
            fruitsThread.Start();
            wordsThread.Start();

            daysThread.Join();
            monthsThread.Join();
            fruitsThread.Join();
            wordsThread.Join();

            Console.WriteLine("Learning completed!");
        }

        static void DisplayDays()
        {
            foreach (string day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000); // Wait 2 seconds before displaying the next day
            }
        }

        static void DisplayMonths()
        {
            foreach (string month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000); // Wait 2 seconds before displaying the next month
            }
        }

        static void DisplayFruits()
        {
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
                Thread.Sleep(1000); // Wait 1 second before displaying the next fruit
            }
        }

        static void DisplayWords()
        {
            foreach (KeyValuePair<string, string> word in words)
            {
                Console.WriteLine("Word: " + word.Key + ", Meaning: " + word.Value);
                Thread.Sleep(1000); // Wait 1 second before displaying the next word
            }
        }
    }
}
