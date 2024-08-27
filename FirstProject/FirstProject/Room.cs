using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Room
    {
        private string section;
        private int totalChairs;
        private string feedback;
        public static int totalRooms = 0;

        public Room(string section, int totalChairs, string feedback)
        {
            Section = section;
            TotalChairs = totalChairs;
            ClassFeedBack = feedback;
            totalRooms++;
        }

        public  int TotalChairs
        {
            get { return this.totalChairs; }

            set
            {
                if (value <= 50)
                {
                    this.totalChairs = value;
                }
                else
                {
                    value = 50;
                }
            }

        }

        public string Section
        {

            get { return this.section; }
            set { this.section = value; }

        }

        public string ClassFeedBack
        {
            get { return this.feedback; }
            set { this.feedback = value; }
        }

        public static void Details(String Details)
        {
            Console.WriteLine(Details);

        }
    }


}
