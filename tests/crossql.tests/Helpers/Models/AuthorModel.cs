using System.Collections.Generic;
using System.Linq;
using crossql.Attributes;

namespace crossql.tests.Helpers.Models
{
    public class AuthorModel : ModelBase
    {
        private List<BookModel> _books;

        public AuthorModel()
        {
            _books = new List<BookModel>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        [Ignore]
        public bool IsCoolName
        {
            get { return FirstName.Contains("e"); }
        }

        [ManyToMany]
        public IEnumerable<BookModel> Books
        {
            get { return _books; }
            private set { _books = (List<BookModel>) value; }
        }

        public void AddBooks(params BookModel[] books)
        {
            _books.AddRange(books);
        }

        public void RemoveBooks(params BookModel[] books)
        {
            _books.RemoveAll(books.Contains);
        }
    }
}