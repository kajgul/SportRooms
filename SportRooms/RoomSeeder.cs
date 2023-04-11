using SportRooms.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SportRooms
{
    public class RoomSeeder
    {
        private readonly SportRoomDbContext _dbContext;
        public RoomSeeder(SportRoomDbContext dbContext)
        {
            _dbContext= dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Bets.Any())
                {
                    //var leagues = GetLeagues();
                    //var rooms = GetRooms();
                    var bets = GetBets();
                    _dbContext.Bets.AddRange(bets);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Bet> GetBets()
        {
            var bets = new List<Bet>()
            {
                new Bet()
                        {
                            PlayerId = 7,
                            MatchId = 7,
                            TeamABet = 1,
                            TeamBBet = 0
                        },
                        new Bet()
                        {
                            PlayerId = 8,
                            MatchId = 8,
                            TeamABet = 1,
                            TeamBBet = 1
                        },
                        new Bet()
                        {
                            PlayerId = 7,
                            MatchId = 7,
                            TeamABet = 1,
                            TeamBBet = 3
                        },
                        new Bet()
                        {
                            PlayerId = 8,
                            MatchId = 8,
                            TeamABet = 0,
                            TeamBBet = 0
                        }

            };
            return bets;
        }

        private IEnumerable<Room> GetRooms()
        {
            var rooms = new List<Room>()
            {
                new Room()
                {
                    Name = "First Test Room",
                    Description = "Test description",
                    Category = "Football",
                    LeagueId = 1,
                    Players = new List<Player>
                    {
                        new Player()
                        {
                            Role = "admin",
                            UserId = 1
                        },
                        new Player() 
                        {
                            Role = "user",
                            UserId = 2
                        }
                    },
                    Matches= new List<Match>()
                    {
                        new Match()
                        {
                            DateOfMatch = System.DateTime.Now,
                            RoundNumber = 1,
                            TeamAName = "Radomiak Radom",
                            TeamBName = "Legia Warszawa",
                            TeamAScore = 2,
                            TeamBScore = 1,
                            LeagueId = 1
                        },
                        new Match()
                        {
                            DateOfMatch = System.DateTime.Now,
                            RoundNumber = 1,
                            TeamAName = "Stal Mielec",
                            TeamBName = "Korona Kielce",
                            TeamAScore = 3,
                            TeamBScore = 0,
                            LeagueId = 1
                        }                        
                    },
                    /*Bets = new List<Bet>()
                    {
                        new Bet()
                        {
                            PlayerId = 1,
                            //MatchId = 1,
                            TeamABet = 1,
                            TeamBBet = 0
                        },
                        new Bet()
                        {
                            PlayerId = 1,
                            //MatchId = 2,
                            TeamABet = 1,
                            TeamBBet = 1
                        },
                        new Bet()
                        {
                            PlayerId = 2,
                            //MatchId = 1,
                            TeamABet = 1,
                            TeamBBet = 3
                        },
                        new Bet()
                        {
                            PlayerId = 2,
                            //MatchId = 2,
                            TeamABet = 0,
                            TeamBBet = 0
                        }
                    }*/
                }
            };
            return rooms;
        }
        private IEnumerable<League> GetLeagues()
        {
            var leagues = new List<League>()
            {
                new League()
                {
                    Name = "Ekstraklasa Polish Football League"
                },
                new League()
                {
                    Name = "Bundesliga"
                }
            };
            return leagues;
        }
    }
}