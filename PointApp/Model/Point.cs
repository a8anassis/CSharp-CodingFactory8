using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point
    {
   
        public int X { get; set; }

        public override string? ToString()
        {
            return $"{X}";
        }

        public virtual void Move5()
        {
            X += 5;
        }
    }
}
