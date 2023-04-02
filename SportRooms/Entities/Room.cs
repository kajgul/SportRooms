using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SportRooms.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }
        public virtual List<Player> Players { get; set; }
        public virtual List<Match> Matches { get; set; }
        public virtual List<Bet> Bets { get; set; }

    }
}
