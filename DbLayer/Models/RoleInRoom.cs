using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class RoleInRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<RoomUser> RoomUsers { get; set; }
    }
}
