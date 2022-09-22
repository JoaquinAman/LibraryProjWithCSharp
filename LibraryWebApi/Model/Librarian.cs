using System.Reflection.Metadata;

namespace LibraryWebApi.Model
{
    public class Librarian
    {
        public long Id { get; set; }

        public Librarian(long id)
        {
            Id = id;
        }

        public Librarian()
        {
        }
    }
}