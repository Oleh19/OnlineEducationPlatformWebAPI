using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public ICollection<Response> Responses { get; set; }
    }
}
