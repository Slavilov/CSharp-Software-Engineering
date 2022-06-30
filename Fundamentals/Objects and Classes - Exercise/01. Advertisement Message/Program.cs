using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    class FakeAdvertisementMessages
    {
        public FakeAdvertisementMessages()
        {
            Phrases = new List<string>();
            Phrases.Add("Excellent product.");
            Phrases.Add("Such a great product.");
            Phrases.Add("I always use that product.");
            Phrases.Add("Best product of its category.");
            Phrases.Add("Exceptional product.");
            Phrases.Add("I can’t live without this product.");

            Events = new List<string>();
            Events.Add("Now I feel good.");
            Events.Add("I have succeeded with this product.");
            Events.Add("Makes miracles. I am happy of the results!");
            Events.Add("I cannot believe but now I feel awesome.");
            Events.Add("Try it yourself, I am very satisfied.");
            Events.Add("I feel great!");

            Authors = new List<string>();
            Authors.Add("Diana");
            Authors.Add("Petya");
            Authors.Add("Stella");
            Authors.Add("Elena");
            Authors.Add("Katya");
            Authors.Add("Iva");
            Authors.Add("Annie");
            Authors.Add("Eva");

            Cities = new List<string>();
            Cities.Add("Burgas");
            Cities.Add("Sofia");
            Cities.Add("Plovdiv");
            Cities.Add("Varna");
            Cities.Add("Ruse");
        }

        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            int randomPhrases = 0;
            int randomEvents = 0;
            int randomAuthors = 0;
            int randomCities = 0;
            FakeAdvertisementMessages FakeMessages = new FakeAdvertisementMessages();


            for (int i = 0; i < numberOfMessages; i++)
            {
                var random = new Random();
                randomPhrases = random.Next(FakeMessages.Phrases.Count);
                randomEvents = random.Next(FakeMessages.Events.Count);
                randomAuthors = random.Next(FakeMessages.Authors.Count);
                randomCities = random.Next(FakeMessages.Cities.Count);

                Console.WriteLine($"{FakeMessages.Phrases[randomPhrases]} {FakeMessages.Events[randomEvents]} {FakeMessages.Authors[randomAuthors]} - {FakeMessages.Cities[randomCities]}");
            }
        }
    }
}