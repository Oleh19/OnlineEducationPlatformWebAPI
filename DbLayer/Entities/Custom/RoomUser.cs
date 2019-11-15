using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class RoomUser : BaseEntity
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
        public RoleInRoom RoleInRoom { get; set; }
    }
}
