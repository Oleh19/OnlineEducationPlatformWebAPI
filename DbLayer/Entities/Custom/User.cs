using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbLayer.Entities.Custom
{
    public class User : BaseEntity
    {
        public int FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Online { get; set; }

        public Photo Photo { get; set; }
        public List<RoomUser> RoomUsers { get; set; }

        [InverseProperty("Owner")]
        public List<Suggestion> SuggestionsGot { get; set; }

        [InverseProperty("Sender")]
        public List<Suggestion> SuggestionsMade { get; set; }
        public List<Notification> Notifications { get; set; }
        public List<FileInstance> Files { get; set; }
        public List<Response> Responses { get; set; }
        public List<Assignment> Assignments { get; set; }

        public Role Role { get; set; }
    }
}
