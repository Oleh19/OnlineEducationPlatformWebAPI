using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Response : BaseEntity
    {
        public string Description { get; set; }

        public Assignment Assignment { get; set; }
        public User User { get; set; }
        public FileInstance File { get; set; }
        public Mark Mark { get; set; }
    }
}
