using MarsProjectEsenturk.Domain.Routing;
using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Factories
{
    public class TaskFactory
    {

        public Area CreateArea(string statement)
        {
            var areaCoordinates = statement.Split(new[] { ' ' }, 2);
            int areaWidth, areaHeight;

            if (areaCoordinates.Length != 2)
            {
                throw new ArgumentException("Area coordinates length must be 2");
            }

            if (int.TryParse(areaCoordinates[0], out areaWidth))
                areaWidth =Convert.ToInt16( areaCoordinates[0]); 
            else
                throw new ArgumentException("Area coordinates has error");



            if (int.TryParse(areaCoordinates[1], out areaHeight))
                areaHeight = Convert.ToInt16(areaCoordinates[1]);
            else
                throw new ArgumentException("Area coordinates has error");

            return new Area(areaWidth, areaHeight);
        }


        public Rover CreateRover(Area area, string statement)
        {
            var RoutingValues = new List<IRouting>()
            {
                new NorthRouting(), new EastRouting(), new WestRouting(), new SouthRouting()
            };

            var positions = statement.Split(new[] { ' ' }, 3);
            int x, y;

            if (positions.Length != 3)
            {
                throw new ArgumentException("Positional Parts must be 3!");
            }

            if (!int.TryParse(positions[0], out x))
            {
                throw new ArgumentException("Positional Parts must be integer!");
            }

            if (!int.TryParse(positions[1], out y))
            {
                throw new ArgumentException("Positional Parts must be integer!");
            }

            var headingCode = positions[2];

            var location = new Location(x, y);
            var routing = RoutingValues.FirstOrDefault(s => s.Code == headingCode);

            if (!RoutingValues.Contains(routing))
            {
                throw new ArgumentException("Routing Type is invalid!");
            }

            return new Rover(area, location, routing);
        }

    }
}
