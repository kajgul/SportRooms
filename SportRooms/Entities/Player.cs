using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRooms.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
