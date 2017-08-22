using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.GreentubeGame.Models;
using Web.GreentubeGame.BLL;
using Greentube;

namespace Web.GreentubeGame.Controllers
{

    public class ReviewInfoAPIController : ApiController
    {
        // GET api/reviewinfoapi

        public dynamic Get()
        {
            var mokedGames = new FakeGamesApi().GetGames();
            
            var responseData = new ReviewInfoBLL().GetReviews();
            var gamesList = responseData.Join(mokedGames, x => x.GameId, y => y.Id, (x, y) => x).ToList();
            var RatingCountByType=new List<RatingCount>();
            RatingCount rt = new RatingCount();
            rt.Count=1;
            rt.RatingType=2;
            RatingCountByType.Add(rt);

            var response = from mokedGame in mokedGames
                        select new
                        {
                            GameId = mokedGame.Id,
                            GameName = mokedGame.Name,
                            Count = responseData.Count(arg => arg.GameId == mokedGame.Id),
                            Rating = (responseData.Count(arg => arg.GameId == mokedGame.Id)!=0)?responseData.Where(arg => arg.GameId == mokedGame.Id).Average(arg => arg.Rating):0,
                            
                            Rating1By = responseData.Where(arg=>arg.Rating==1).Count(arg => arg.GameId == mokedGame.Id),
                            Rating2By = responseData.Where(arg => arg.Rating == 2).Count(arg => arg.GameId == mokedGame.Id),
                            Rating3By = responseData.Where(arg => arg.Rating == 3).Count(arg => arg.GameId == mokedGame.Id),
                            Rating4By = responseData.Where(arg => arg.Rating == 4).Count(arg => arg.GameId == mokedGame.Id),
                            Rating5By = responseData.Where(arg => arg.Rating == 5).Count(arg => arg.GameId == mokedGame.Id)
                        };

            return response;
        }

        // GET api/reviewinfoapi/5
        
        public IEnumerable<ReviewInfo> Get(int id)
        {
            return new ReviewInfoBLL().GetReviewByGameId(id);
        }

        // POST api/reviewinfoapi
        public ReviewInfo Post([FromBody]ReviewInfo pRequest)
        {
            return new ReviewInfoBLL().CreateReview(pRequest);
        }

    }
    public class RatingCount
    {
        public int RatingType { get; set; }
        public int Count { get; set; }
    }
}
