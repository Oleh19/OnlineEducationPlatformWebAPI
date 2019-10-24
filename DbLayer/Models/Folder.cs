using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Folder
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public Room Room { get; set; }
    }
}
