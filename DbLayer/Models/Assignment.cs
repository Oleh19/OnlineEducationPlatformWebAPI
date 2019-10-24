using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndingDate { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
        public File File { get; set; }
        public ICollection<Response> Responses { get; set; }
    }
}
