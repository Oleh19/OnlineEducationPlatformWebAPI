using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }


        public List<User> Users { get; set; }
    }
}
