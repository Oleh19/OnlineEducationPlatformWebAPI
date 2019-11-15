using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }

        public Folder Folder { get; set; }
        public List<RoomUser> RoomUsers { get; set; }
    }
}
