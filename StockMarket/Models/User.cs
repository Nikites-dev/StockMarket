using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Models
{
    public class User
    {
        public User()
        {

        }
        [BsonIgnoreIfDefault]
        
        public ObjectId _id;
        [BsonIgnoreIfNull]

        public String FName { get; set; }
        [BsonIgnoreIfNull]
        public String LName { get; set; }
        [BsonIgnoreIfNull]
        public String DateBirth { get; set; }
        [BsonIgnoreIfNull]
        public String Login { get; set; }
        [BsonIgnoreIfNull]
        public String Password { get; set; }
        [BsonIgnoreIfNull]
        public int Balance { get; set; }
        [BsonIgnoreIfNull]
        public List<Item> listBasket = new List<Item>();
        [BsonIgnoreIfNull]
        public List<Item> listPurchasedItems= new List<Item>();
    }
}
