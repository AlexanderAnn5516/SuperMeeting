using SuperMetting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMeeting_.Data
{
    public class Groups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public List<ActiveOpenUsers> Users { get; set; }
        public Meetings Meeting { get; set; }

    }
}
