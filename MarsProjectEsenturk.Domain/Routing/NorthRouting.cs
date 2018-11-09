using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Routing
{
    public class NorthRouting : IRouting
    {
        public string Code => "N";

        public Location Move(Location location)
        {
            return new Location(location.X, location.Y + 1);
        }

        public IRouting TurnRight()
        {
            return new EastRouting();
        }

        public IRouting TurnLeft()
        {
            return new WestRouting();
        }
    }
}
