using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProjectEsenturk.Domain.DomainModels;

namespace MarsProjectEsenturk.Domain.Routing
{

    public interface IRouting
    {
        string Code { get; }
        Location Move(Location location);
        IRouting TurnRight();
        IRouting TurnLeft();
    }

}
