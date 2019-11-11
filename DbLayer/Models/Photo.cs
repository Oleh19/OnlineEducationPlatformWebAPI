using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Path { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }
    }
}
