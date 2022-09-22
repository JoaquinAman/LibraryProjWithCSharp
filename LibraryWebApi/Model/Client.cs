namespace LibraryWebApi.Model
{
    public class Client
    {
        public long Id { get; set; }
        public Client()
        {
        }

        public Client(long id)
        {
            Id = id;
        }
    }
}