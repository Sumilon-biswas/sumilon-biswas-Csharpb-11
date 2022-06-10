using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Clock
    {
        public string Convert(string twelveHourTime)
        {
            DateTime d = DateTime.Parse(twelveHourTime);
            return d.ToString("HH:mm");
        }
    }
}
