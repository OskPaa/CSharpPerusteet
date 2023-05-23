using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKoe
{
    class JavelinThrow
    {
        // Properties
        public int Id { get; set; }
        public string AthleteName { get; set; }
        public int Meters { get; set; }
        public int Centimeters { get; set; }
        // Constructor
        public JavelinThrow(int id,string athleteName,int meters,int centimeters)
        {
            Id = id;
            AthleteName = athleteName;
            Meters = meters;
            Centimeters = centimeters;
        }
    }
}
