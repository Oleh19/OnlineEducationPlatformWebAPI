using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Response
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Assignment Assignment { get; set; }
        public User User { get; set; }
        public File File { get; set; }
        public Mark Mark { get; set; }
    }
}
