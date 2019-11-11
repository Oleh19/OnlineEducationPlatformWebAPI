using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<File> Files { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
