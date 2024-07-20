namespace Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ebook ebook = new Ebook();
            ebook.Title = "tai";
            ebook.Author = "tai";
            ebook.ISBN = 32;
            ebook.FileSize = 3;
            ebook.Format = "tai";


            PrintedBook printedBook = new PrintedBook();
            printedBook.Title = "dung";
            printedBook.Author = "dung";
            printedBook.ISBN = 32;
            printedBook.Publisher = "dung";
            printedBook.PageCount = 3.5;

            List<Book> listBook = new List<Book>();


            listBook.Add(printedBook);
            listBook.Add(ebook);


            for (int i = 0; i < listBook.Count; i++)
            {
                Console.WriteLine("*************<3****<3****<3*****<3**********");
                listBook[i].DisplayInfo();
            }
        }
    }
}