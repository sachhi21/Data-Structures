using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.InterviewQuestions
{
    public class timeConversion
    {
        public static string s12Into24hour(string s )
        {
            string period = s.Substring(s.Length - 2);  // "AM" or "PM"

            int hour = int.Parse(s.Substring(0, 2));

            string minutesAndSeconds = s.Substring(2, 6);  // ":MM:SS"

            if (period == "AM")
            {
                if (hour == 12)
                {
                    hour = 0;
                }
            }
            else if (period == "PM")
            {
                if (hour != 12)
                {
                    hour += 12;
                }
            }

            return $"{hour:D2}{minutesAndSeconds}";
        }
    
    }
}
