using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public User Owner { get; set; }
        public Assignment Assignment { get; set; }
        public Response Response { get; set; }
    }
}
