using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Routing
{
    public class WestRouting : IRouting
    {
        public string Code => "W";

        public Location Move(Location location)
        {
            return new Location(location.X - 1, location.Y);
        }

        public IRouting TurnRight()
        {
            return new NorthRouting();
        }

        public IRouting TurnLeft()
        {
            return new SouthRouting();
        }
    }
}
