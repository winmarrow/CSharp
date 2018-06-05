using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lecture_1_7
{
    public class BookLibrary
    {
        public readonly Dictionary<Guid, Book> Books = new Dictionary<Guid, Book>();
        public readonly Dictionary<Author, List<Guid>> Authors = new Dictionary<Author, List<Guid>>();

        //Is Valid
        private bool IsBookValid(Book book)
        {
            return !string.IsNullOrWhiteSpace(book?.Title)
                   && book.Author != null;
        }
        private bool IsAuthorValid(Author author)
        {
            return !string.IsNullOrWhiteSpace(author?.FirstName)
                   && !string.IsNullOrWhiteSpace(author.LastName)
                   && author.DoB != new DateTime();
        }

        //IsContain
        public bool IsContainBook(Guid bookId)
        {
            if (bookId != Guid.Empty) return false;
            return Books.ContainsKey(bookId);
        }
        public bool IsContainBook(Book book)
        {
            if (!IsBookValid(book)) return false;
            return Books.ContainsValue(book);
        }
        public bool IsContainAuthor(Author author)
        {
            if (!IsAuthorValid(author)) return false;
            return Authors.ContainsKey(author);
        }

        //Add
        public Guid AddBook(Book book)
        {
            if (IsContainBook(book)) return Guid.Empty;

            var bookId = Guid.NewGuid();
            Books.Add(bookId, book);

            if(!IsContainAuthor(book.Author))
                Authors.Add(book.Author,new List<Guid>(){ bookId });
            else
                Authors[book.Author].Add(bookId);

            return bookId;
        }
        public bool AddAuthor(Author author)
        {
            if (IsContainAuthor(author)) return false;

            Authors.Add(author, new List<Guid>());

            return true;
        }

        //Remove
        public bool RemoveBook(Guid bookId)
        {
            if (!IsContainBook(bookId)) return false;

            Books.Remove(bookId);

            return true;
        }
        public bool RemoveAuthor(Author author)
        {
            if (!IsContainAuthor(author)) return false;

            foreach (var bookId in Authors[author])
                Books.Remove(bookId);

            Authors.Remove(author);

            return true;
        }

        //Set book status
        public void SetBookAvailability(Guid bookId, bool availability)
        {
            if (!IsContainBook(bookId)) return;
            Books[bookId].IsAvailable = availability;
        }

        
    }
}
