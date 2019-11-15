using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class RoleInRoom : BaseEntity
    {
        public string Name { get; set; }

        public List<RoomUser> RoomUsers { get; set; }
    }
}
