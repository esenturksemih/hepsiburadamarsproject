using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.DomainModels
{
    public class Location
    {
        public Location(int x, int y)
        {
          
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }
    }
}
