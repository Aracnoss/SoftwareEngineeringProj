using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngProj
{
    class Participants
    {
        public static int NumberOfStaff = 0;

        public int staffNumber { get; private set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public DateTime[][] available { get; set; } //Just placeholder for now
        public Boolean active { get; set; }
        public Boolean important { get; set; }
        public Meeting Meetings { get; set; }

        //Read from file
        public Participants()
        {
        }

        //Take all manually
        public Participants(string firstName, string surname, DateTime[][] available)
        {
            staffNumber = NumberOfStaff++;
            this.firstName = firstName;
            this.surname = surname;
            this.available = available;
        }
    }
}