/*
 * NAME SURNAME : MEHMET EMRE TOPAL
 * NUMBER : B221202075
 * HONOR CODE
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopdeneme
{
    public class RGBColor
    {
        public int red { get; set; }
        public int blue { get; set; }
        public int green { get; set; }

        public RGBColor()
        {
            Random random = new Random();

            red = random.Next(0, 255);
            green = random.Next(0, 255);
            blue = random.Next(0, 255);
        }

    }
}
