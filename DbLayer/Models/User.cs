using System;
using System.Collections.Generic;
using System.Text;

namespace DbLayer.Models
{
    public class User
    {
        public int Id { get; set; }
        public int FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Online { get; set; }

        public File Photo { get; set; }
        public ICollection<RoomUser> RoomUsers { get; set; }
        public ICollection<Suggestion> Suggestions { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<File> Files { get; set; }
        public ICollection<Response> Responses { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

        public Role Role { get; set; }
    }
}
