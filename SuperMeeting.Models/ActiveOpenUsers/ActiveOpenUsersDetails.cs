using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMeeting.Models.ActiveOpenUsers
{
    public class ActiveMicroUsersDetails
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool isInGroup { get; set; }
        public string GroupName { get; set; }
    }
}
