using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Folder Folder { get; set; }
        public List<RoomUser> RoomUsers { get; set; }
    }
}
