using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Routing
{
    public class EastRouting : IRouting
    {
        public string Code => "E";
        public Location Move(Location location)
        {
            return new Location(location.X + 1, location.Y);
        }

        public IRouting TurnRight()
        {
            return new SouthRouting();
        }

        public IRouting TurnLeft()
        {
            return new NorthRouting();
        }
    }
}
