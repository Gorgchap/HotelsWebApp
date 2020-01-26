namespace Models
{
    public class RoomModel
    {
        public int Id { get; }
        public int? Number { get; }
        public int? Price { get; }
        public string RoomType { get; }
        public RoomModel(int id, int? number, int? price, string type) { Id = id; Number = number; Price = price; RoomType = type; }
    }
}
