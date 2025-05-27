namespace Repository
{
    internal class Book
    {
        public string Author;
        public string BookName;
        public int Page;



        public Book() { }


        public Book(string author, string BookName)

        {
            author = author;
            BookName = BookName;


            Console.WriteLine($"Author:{author}, BookName:{BookName}");
        }



    }
}
