using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class RoomUser
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
        public RoleInRoom RoleInRoom { get; set; }
    }
}
