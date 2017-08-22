using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Web.GreentubeGame.Models
{
    public class ReviewInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
      //  public Object Id { get; set; }
        [BsonElement("GameId")]
        public int GameId { get; set; }
        [BsonElement("GameName")]
        public string GameName { get; set; }
        [BsonElement("UserNick")]
        public string UserNick { get; set; }
        [BsonElement("Rating")]
        public int Rating { get; set; }
    }
}