using System;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nAvailability: {(IsAvailable ? "Available" : "Not Available")}";
        }
    }
}
