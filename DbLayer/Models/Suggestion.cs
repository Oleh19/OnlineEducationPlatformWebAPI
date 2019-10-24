using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Suggestion
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public User Owner { get; set; }
        public User Sender { get; set; }
        public Room Room { get; set; }
    }
}
