using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Assignment : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndingDate { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
        public FileInstance File { get; set; }
        public List<Response> Responses { get; set; }
    }
}
