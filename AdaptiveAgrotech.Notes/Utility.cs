using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveAgrotech.Notes
{
    public class Utility
    {
        public static bool IsLight(System.Drawing.Color col)
        {

            if (col.R * 0.2126 + col.G * 0.7152 + col.B * 0.0722 > 255 / 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
