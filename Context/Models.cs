using System.Collections.Generic;
using System.Linq;

namespace Context
{
    public class UserModel
    {
        public int Id { get; }
        public string Login { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public string Phone { get; }
        public UserModel(int id, string login, string name, string surname, string email, string phone) { Id = id; Login = login; Name = name; Surname = surname; Email = email; Phone = phone; }
    }

    public class HotelModel
    {
        readonly int max = 5;
        public int Id { get; }
        public string Name { get; }
        public string City { get; }
        public string Address { get; }
        public string Rating { get; }
        public string Conveniences { get; }     
        public HotelModel(int id, string name, string city, string address, int? rating, ICollection<ConvHotel> convs)
        {
            Id = id; Name = name; City = city; Address = address;
            for (int i = 0; i < max; i++) Rating += i < rating ? '★' : '☆';
            Conveniences = string.Join("   ", convs.Select(c => c.Convenience.ConvName));
        }
    }

    public class RoomModel
    {
        public int Id { get; }
        public int? Number { get; }
        public int? Price { get; }
        public string RoomType { get; }
        public RoomModel(int id, int? number, int? price, string type) { Id = id; Number = number; Price = price; RoomType = type; }
    }
}
