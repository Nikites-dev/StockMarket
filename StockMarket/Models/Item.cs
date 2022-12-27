using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StockMarket.Models
{
    public class Item
    {
        [BsonIgnoreIfDefault]
        
        public ObjectId _id;
        [BsonIgnoreIfNull]
        public String Name { get; set; }
        [BsonIgnoreIfNull]
        public byte[] Image { get; set; }
        [BsonIgnoreIfNull]
        public int Price{ get; set; }
    }
}
