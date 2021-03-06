﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProjectEsenturk.Domain.Routing;
using MarsProjectEsenturk.Domain.Exceptions;

namespace MarsProjectEsenturk.Domain.DomainModels
{
    public class Rover
    {
        private readonly Area _area;
        private Location _location;
        private IRouting _heading;


        public Rover(Area area, Location location, IRouting heading)
        {
            _area = area;
            _location = location;
            _heading = heading;
        }
        public Location Location
        {
            get { return _location; }
        }

        public Area Area
        {
            get { return _area; }
        }

        public IRouting Heading
        {
            get { return _heading; }
        }

        public Dictionary<char, Action> ProcessAction { get; private set; }


        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException($"Invalid routing: {command}");
                }
            }
        }

        public void Move()
        {
            var location = _heading.Move(_location);
            if (!_area.IsCorrectLocation(location))
                throw new OutOfArrangeException();

            _location = location;
        }

        public void TurnRight()
        {
            _heading = _heading.TurnRight();
        }

        public void TurnLeft()
        {
            _heading = _heading.TurnLeft();
        }

        public override string ToString()
        {
            return $"{_location.X} {_location.Y} {_heading.Code}";
        }

    }
}
