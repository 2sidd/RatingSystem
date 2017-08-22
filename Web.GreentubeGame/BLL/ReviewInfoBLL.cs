using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GreentubeGame.Models;
using Web.GreentubeGame.DAL;

namespace Web.GreentubeGame.BLL
{
    public class ReviewInfoBLL
    {
        // Pending task
        // Dependency Injection of class insted of creating instense every time;
        public IEnumerable<ReviewInfo> GetReviews()
        {
            var responseData = new ReviewInfoDAL().GetReviews();
             //var temp2 = from response in responseData select  new 

            //var UniqueRec = from response in responseData select new {
            //    response.GameId,response.GameName,Rating = responseData.Where(arg=>arg.GameId==response.GameId).Average(arg=>arg.Rating)
            //};
            return responseData;

        }
        public IEnumerable<ReviewInfo> GetReviewByGameId(int pGameId)
        {
            return new ReviewInfoDAL().GetReviewByGameId(pGameId);
        }
        public ReviewInfo CreateReview(ReviewInfo pReviewInfo)
        {
            return new ReviewInfoDAL().CreateReview(pReviewInfo);
        }
    }
}