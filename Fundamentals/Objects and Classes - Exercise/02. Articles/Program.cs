using System;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

namespace SongsExerciseForObjectsAndClasses
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Editing(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthoring(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Renaming(string newTitle)
        {
            this.Title = newTitle;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputArticle = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Article newArticle = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
            int numOfCommands = int.Parse(Console.ReadLine());

            Article newArticleObject = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);

            for (int i = 0; i < numOfCommands; i++)
            {
                List<string> inputCommands = Console.ReadLine().Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string commands = inputCommands[0];

                if (commands == "Edit")
                {
                    newArticleObject.Editing(inputCommands[1]);
                }
                else if (commands == "ChangeAuthor")
                {
                    newArticleObject.ChangeAuthoring(inputCommands[1]);
                }
                else
                {
                    newArticleObject.Renaming(inputCommands[1]);
                }
            }

            Console.WriteLine($"{newArticleObject.Title} -{newArticleObject.Content}:{newArticleObject.Author}");
        }
    }
}