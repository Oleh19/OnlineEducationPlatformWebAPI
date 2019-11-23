using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Invitation : BaseEntity
    {
        public User Owner { get; set; }
        public User Sender { get; set; }
        public Room Room { get; set; }
    }
}
