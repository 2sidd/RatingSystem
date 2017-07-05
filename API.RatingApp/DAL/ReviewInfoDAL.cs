using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Web.GreentubeGame.Models;

namespace Web.GreentubeGame.DAL
{
    public class ReviewInfoDAL
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        public ReviewInfoDAL()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("gameDatabase");      
        }
        public IEnumerable<ReviewInfo> GetReviews()
        {
            var response =_db.GetCollection<ReviewInfo>("ReviewInfo").FindAll();
            return response;
        }
        public IEnumerable<ReviewInfo> GetReviewByGameId(int pGameId)
        {
            var query = Query<ReviewInfo>.EQ(p=>p.GameId,pGameId);
            return _db.GetCollection<ReviewInfo>("ReviewInfo").Find(query).ToList();

        }
        public ReviewInfo CreateReview(ReviewInfo pReviewInfo)
        {
           _db.GetCollection<ReviewInfo>("ReviewInfo").Save(pReviewInfo);
           return pReviewInfo;
        }

    }
}