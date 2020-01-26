namespace Models
{
    class NewHotelModel
    {
        public string Name { get; }
        public string City { get; }
        public string Address { get; }
        public int? Rating { get; }
        public NewHotelModel(string name, string city, string address, int? rating) { Name = name; City = city; Address = address; Rating = rating; }
    }
}
