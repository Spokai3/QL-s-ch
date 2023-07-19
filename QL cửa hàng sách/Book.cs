using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_cửa_hàng_sách
{
    [Serializable]
    public class Book
    {
        [BsonId, BsonElement("bookID"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int BookID { get; set; }

        [BsonElement("ISBN"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ISBN { get; set; }

        [BsonElement("author"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string author { get; set; }

    }
}
