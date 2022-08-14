using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMeeting_.Data
{
    public class ActiveOpenUsers
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get 
            { 
                return Name; 
            } 
            set
            {
                Name = FirstName + " " + LastName;
            } 
        }
        public string Email { get; set; }
        public bool isInGroup { get; set; }
        public Groups Group { get; set; }

    }
}
