using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMeeting.Models.ActiveOpenUsers
{
    internal class ActiveMicroUsersListItem
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
