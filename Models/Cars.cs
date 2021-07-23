using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialApp.Models
{
    public class Cars
    {

        public int Id { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mpg { get; set; }
        public int TankSize { get; set; }
        public int Gas { get; set; }

        public Cars()
        {

        }

    }
}
