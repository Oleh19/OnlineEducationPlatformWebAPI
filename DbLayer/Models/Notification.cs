using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Read { get; set; }

        public User Owner { get; set; }
        public Room Room { get; set; }
    }
}
