using System;

using System.Text;

using System.Numerics;

using System.Linq;

using System.Collections.Generic;



namespace SongsExerciseForObjectsAndClasses

{

    class Song

    {

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }

    class Program

    {

        static void Main(string[] args)

        {

            int numberOfSongs = int.Parse(Console.ReadLine());



            List<string> inputList = new List<string>();

            List<Song> songs = new List<Song>();



            for (int i = 1; i <= numberOfSongs; i++)

            {

                string input = Console.ReadLine();

                inputList = input.Split('_', StringSplitOptions.RemoveEmptyEntries).ToList();



                string typeList = inputList[0];

                string name = inputList[1];

                string time = inputList[2];



                Song newSong = new Song()

                {

                    TypeList = typeList,

                    Name = name,

                    Time = time

                };



                songs.Add(newSong);

            }

            string command = Console.ReadLine();



            if (command == "all")

            {

                foreach (Song song in songs)

                {

                    Console.WriteLine(song.Name);

                }

            }

            else

            {

                foreach (Song song in songs)

                {

                    if (song.TypeList == command)

                    {

                        Console.WriteLine(song.Name);

                    }

                }

            }

        }

    }

}