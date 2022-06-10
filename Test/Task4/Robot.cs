using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Robot
    {
        public double Speed { get; set; }
        public Status  { get; set; }
        public int position;

        public abstract void Move(double amount)
        {

        }

    }

    enum Status
    {
        On,
        Off,
    }
}
