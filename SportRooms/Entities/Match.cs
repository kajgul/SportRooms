using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRooms.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime DateOfMatch { get; set; }
        public int RoundNumber { get; set; }
        public string TeamAName { get; set; }
        public string TeamBName { get; set; }
        public byte TeamAScore { get; set; }
        public byte TeamBScore { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }

    }
}
