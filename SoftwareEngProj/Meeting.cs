using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngProj
{
    class Meeting
    {
        public static int NumberOfMeetings = 0;

        public int meetingNumber { get; private set; }
        public String meetingName { get; set; }
        public String meetingInitiator { get; private set; }
        public String meetingDesc { get; set; }
        public Participants[] participants { get; set; }
        public DateTime[] dateRange { get; set; }

        //Creating a meeting
        public Meeting()
        {
            dateRange = new DateTime[2];
        }

        //Take all manually
        public Meeting(string meetingName, string meetingInitator, string meetingDesc, Participants[] participants, DateTime[] dateRange)
        {
            meetingNumber = NumberOfMeetings++;
            this.meetingName = meetingName;
            this.meetingInitiator = meetingInitator;
            this.meetingDesc = meetingDesc;
            this.participants = participants;
            this.dateRange = dateRange;
        }
    }
}
