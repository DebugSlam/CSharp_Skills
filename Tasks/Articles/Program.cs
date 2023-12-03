namespace Articles;


class Program
{
    static void Main(string[] args)
    {
        
        string information = Console.ReadLine();

       

        string[] informationArray = information.Split(", ");
        string title = informationArray[0];
        string content = informationArray[1];
        string author = informationArray[2];

        Article currentArticle = new Article
        {

            Title = title,
            Content = content,
            Author = author

        };

     


        int number = int.Parse(Console.ReadLine());
        information = Console.ReadLine();

        for (int i = 0; i < number; i++)
        {
            informationArray = information.Split(": ").Select(x => x.Trim()).ToArray();
            string command = informationArray[0];
            content = informationArray[1];

            if (command == "Edit")
            {
                currentArticle.Edit(content);
            }

            else if (command == "ChangeAuthor")
            {
                currentArticle.ChangeAuthor(content);
            }


            else if (command == "Rename")
            {

                currentArticle.Rename(content);

            }

            information = Console.ReadLine();
        }


        Console.WriteLine($"{currentArticle.Title} - {currentArticle.Content}: {currentArticle.Author}");

    }

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string content)
        {
            
            
                this.Content = content;
            
        }


        public void ChangeAuthor(string author)
        {
                this.Author = author;
            
        }

        public void Rename(string title)
        {
                this.Title = title;
            
        }

      

    }
}
