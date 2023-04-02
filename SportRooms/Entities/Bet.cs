using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRooms.Entities
{
    public class Bet
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        public int MatchId { get; set; }
        public virtual Match Match { get; set; }
        public int TeamABet { get; set; }
        public int TeamBBet { get; set; }
    }
}
