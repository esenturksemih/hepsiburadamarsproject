using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Routing
{
    public class SouthRouting : IRouting
    {
        public string Code => "S";

        public Location Move(Location location)
        {
            return new Location(location.X, location.Y - 1);
        }

        public IRouting TurnRight()
        {
            return new WestRouting();
        }

        public IRouting TurnLeft()
        {
            return new EastRouting();
        }
    }
}
