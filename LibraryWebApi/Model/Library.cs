namespace LibraryWebApi.Model
{
    public class Library
    {
        public List<Book> BookList { get; set; }
        public Library(){}
        public Library(List<Book> bookList)
        {
            BookList = bookList;
        }
    }
}