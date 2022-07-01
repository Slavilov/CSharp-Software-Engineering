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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article> ListOfArticles = new List<Article>();

            for (int i = 0; i < numOfArticles; i++)
            {
                List<string> inputArticle = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Article newArticle = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
                ListOfArticles.Add(newArticle);
            }
            string input = Console.ReadLine();

            foreach (Article article in ListOfArticles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
}