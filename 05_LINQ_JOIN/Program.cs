namespace _05_LINQ_JOIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Author> listAuthor = new List<Author>();
            listAuthor.Add(new Author() { Id =1, Name = "Joao" });
            listAuthor.Add(new Author() { Id = 2, Name = "Maria" });
            listAuthor.Add(new Author() { Id = 3, Name = "Jose" });

            List<Book> listBook = new List<Book>();
            listBook.Add(new Book() { Id = 1, AuthorId = 2, Title = "Amor amado" });
            listBook.Add(new Book() { Id = 2, AuthorId = 2, Title = "Bem amado" });
            listBook.Add(new Book() { Id = 3, AuthorId = 3, Title = "O espião" });
            listBook.Add(new Book() { Id = 4, AuthorId = 1, Title = "A vida na terra" });

            var listJoin = from books in listBook join author in listAuthor on books.AuthorId equals author.Id select new{ books, author};
            foreach (var item in listJoin) 
            { 
                Console.WriteLine("Livro: "+item.books.Title + " - Autor: "+ item.author.Name);
            }
            Console.ReadKey();
        }
    }
}