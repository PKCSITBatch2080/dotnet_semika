using System.Collections.Generic;

namespace LibraryManagement
{
    public class Library
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            string bookList = "";
            foreach (var book in Books)
            {
                bookList += book.ToString() + "\n\n";
            }

            return $"Library: {Name}\nLocation: {Location}\n\nBooks:\n{bookList}";
        }
    }
}
