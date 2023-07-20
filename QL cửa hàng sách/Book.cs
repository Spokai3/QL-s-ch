using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace QL_cửa_hàng_sách
{
    [Serializable]
    public class Book
    {
        [BsonId,BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("bookID"), BsonRepresentation(BsonType.Int32)]
        public int BookID { get; set; }

        [BsonElement("isbn"), BsonRepresentation(BsonType.String)]
        public string ISBN { get; set; }

        [BsonElement("title"), BsonRepresentation(BsonType.String)]
        public string Tên_Sách { get; set; }

        [BsonElement("authors"), BsonRepresentation(BsonType.String)]
        public string Tác_Giả { get; set; }

        [BsonElement("language_code"), BsonRepresentation(BsonType.String)]
        public string Ngôn_Ngữ { get; set; }

        [BsonElement("publisher"), BsonRepresentation(BsonType.String)]
        public string Nhà_Xuất_Bản { get; set; }

        [BsonElement("publication_date"), BsonRepresentation(BsonType.String)]
        public string Ngày_Công_Bố { get; set; }

    }
}
