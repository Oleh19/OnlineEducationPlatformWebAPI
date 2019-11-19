using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class FileInstance : BaseEntity
    {
        public string Path { get; set; }

        public User CreatedBy { get; set; }
        public Folder Folder { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int ResponseId { get; set; }
        public Response Response { get; set; }
    }
}
