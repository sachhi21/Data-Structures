using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Utils
{
    public class Incident
    {
        

        public int Id { get; set; }
        public string IncidentName { get; set; }
        public string? IncidentDescription { get; set; }
        public string? IncidentType { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string? Location { get; set; }

      

    }
}
