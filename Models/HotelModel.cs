namespace Models
{
    public class HotelModel
    {
        readonly int max = 5;
        public int Id { get; }
        public string Name { get; }
        public string City { get; }
        public string Address { get; }
        public string Rating { get; }
        public HotelModel(int id, string name, string city, string address, int? rating)
        {
            Id = id; Name = name; City = city; Address = address;
            for (int i = 0; i < max; i++) Rating += i < rating ? '★' : '☆';
        }
    }
}
