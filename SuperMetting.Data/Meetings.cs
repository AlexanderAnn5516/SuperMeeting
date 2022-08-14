using SuperMeeting_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMetting.Data
{
    public class Meetings
    {
        public int MeetingId { get; set; }
        public string MeetingName { get; set; }
        public Groups Group { get; set; }
        public ActiveMicroUsers Users { get; set; }
    }
}
