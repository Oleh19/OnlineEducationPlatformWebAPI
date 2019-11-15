using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Notification : BaseEntity
    {
        public string Description { get; set; }
        public bool Read { get; set; }

        public User Owner { get; set; }
        public Room Room { get; set; }
    }
}
