using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Photo : BaseEntity
    {
        public string Path { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
    }
}