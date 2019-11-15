using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Folder : BaseEntity
    {
        public string Path { get; set; }

        public List<File> Files { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
