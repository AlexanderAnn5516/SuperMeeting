﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMeeting.Models.Groups
{
    internal class MeetingListItem
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int NumOfUsers { get; set; }
    }
}
