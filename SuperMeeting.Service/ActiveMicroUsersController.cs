using SuperMeeting.Models.ActiveMicroUsers;
using SuperMetting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SuperMeeting.Service
{
    public class ActiveMicroUsersController : Controller
    {
        private List<ActiveMicroUsers> microUsers = new List<ActiveMicroUsers>();
        public void Station()
        {
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            Console.WriteLine("enter meetingName");
            string meeting = Console.ReadLine();
            Console.WriteLine("creating user");
            Create(email, meeting);
            if 
        }
        public ActiveMicroUsers Create(string email, string meeting)
        {
            return(Add(new ActiveMicroUsers { Email = email, MeetingName = meeting}));
        }
        public ActiveMicroUsers Add(ActiveMicroUsers item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            microUsers.Add(item);
            return item;
        }
    }
}
 