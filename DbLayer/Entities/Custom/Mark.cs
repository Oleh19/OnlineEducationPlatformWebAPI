using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class Mark : BaseEntity
    {
        public int Value { get; set; }

        public List<Response> Responses { get; set; }
    }
}
