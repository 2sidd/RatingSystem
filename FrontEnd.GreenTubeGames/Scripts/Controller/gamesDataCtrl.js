var app = angular.module('greenTubeGames', []);

app.controller('gamesDataCtrl', function ($scope, $http) {
    $http.get(baseUrl+"reviewinfoapi")
    .then(function (response) {
        $scope.gamesList = [];
        for (var i = 0; i < response.data.length; i++) {
            var gameRating = [{ 'RatingType': 1, 'RatingCount': response.data[i].Rating1By },
                              { 'RatingType': 2, 'RatingCount': response.data[i].Rating2By },
                              { 'RatingType': 3, 'RatingCount': response.data[i].Rating3By },
                              { 'RatingType': 4, 'RatingCount': response.data[i].Rating4By },
                              { 'RatingType': 5, 'RatingCount': response.data[i].Rating5By }];
            var gamedata = {
                'Count': response.data[i].Count,
                'GameId': response.data[i].GameId,
                'GameName': response.data[i].GameName,
                'Rating': response.data[i].Rating,
                'gameRating': gameRating
            };
            $scope.gamesList.push(gamedata);
        }
    });
    $scope.rating = 1;
    $scope.nickName = " ";
    $scope.isLoggedIn = false;
    $scope.Logout=function(){
        deleteCookie('nickName');
        $scope.isLoggedIn = false;
        location.reload();
    },
    $scope.Login = function (nickName) {
      if(nickName!=undefined)
          document.cookie = "nickName=" + nickName;
          $scope.isLoggedIn = true;
      location.reload();
    };
    $scope.loadData = function () {
        var logedInUserNick = getCookieValue('nickName');
        if (logedInUserNick != '') {
            alert("Welcome Back: " + logedInUserNick);
            $scope.nickName = logedInUserNick;
            $scope.isLoggedIn = true;
        }
        else {
            $scope.isLoggedIn = false;
            $('a span:nth-child(2)').click(function (event) { event.preventDefault(); });
        }
    }();

    $scope.GameDetails = function (x) {
        $scope.selectedGame = x;
        angular.element('#gameDetailWindowModal').modal();
    }

    $scope.rateFunction = function (x,rating) {
        var reqObj = { "GameId":x.GameId, "GameName": x.GameName, "Rating": rating }

        var config = {
            headers: {
                'Content-Type': 'application/json;'
            }
        }
        $http.post(
                baseUrl+'reviewinfoapi',
                JSON.stringify(reqObj),
                {
                    headers: {
                        'Content-Type': 'application/json'
                    }
                }
            ).then(function (data) {
                $scope.response = data;
            });
    };
}).directive('starRating',
	function () {
	    return {
	        restrict: 'A',
	       
	        template: '<ul class="rating" readonly>'
					 + '	<li ng-repeat="star in stars" ng-class="star" ng-click="toggle($index)">'
					 + '\u2605'
					 + '</li>'
					 + '</ul>',
	        scope: {
	            ratingValue: '=',
	            max: '=',
	            onRatingSelected: '&'
	        },
	        link: function (scope, elem, attrs) {
	            var updateStars = function () {
	                scope.stars = [];
	                for (var i = 0; i < scope.max; i++) {
	                    scope.stars.push({  
	                        filled: i < scope.ratingValue
	                    });
	                }
	            };

	            scope.toggle = function (index) {
	                scope.ratingValue = index + 1;
	                scope.onRatingSelected({
	                    rating: index + 1
	                });
	            };

	            scope.$watch('ratingValue',
					function (oldVal, newVal) {
					    updateStars();
					}
				);
	        }
	    };
	}
);