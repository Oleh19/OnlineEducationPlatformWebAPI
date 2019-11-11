using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public User CreatedBy { get; set; }
        public Folder Folder { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int ResponseId { get; set; }
        public Response Response { get; set; }
    }
}
