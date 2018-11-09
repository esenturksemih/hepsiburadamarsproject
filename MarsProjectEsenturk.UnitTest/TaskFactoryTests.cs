using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MarsProjectEsenturk.Domain;
using MarsProjectEsenturk.Domain.Routing;
using MarsProjectEsenturk.Domain.DomainModels;
using NUnit.Framework;

namespace MarsProjectEsenturk.UnitTest
{
    [TestFixture]
    public class TaskFactoryTests
    {

        [TestCase(5, 5, "0 0 W", typeof(WestRouting))]
        [TestCase(5, 5, "0 0 S", typeof(SouthRouting))]
        [TestCase(5, 5, "1 2 N", typeof(NorthRouting))]
        [TestCase(5, 5, "3 3 E", typeof(EastRouting))]   
        public void RoverCreationFromSyntax(int areaWidth, int areaHeight, string statement, Type T)
        {
            var area = new Area(areaWidth, areaHeight);
            var roverFactory = new Domain.Factories.TaskFactory();

            var rover = roverFactory.CreateRover(area, statement);

            rover.Area.Width.Should().Be(areaWidth);
            rover.Area.Height.Should().Be(areaHeight);
            rover.Heading.Should().BeOfType(T);

            rover.ToString().Should().Be(statement);
        }
        [TestCase("5 4", 5, 4)]
        [TestCase("3 1", 3, 1)]
        public void AreaCreationFromSyntax(string statement, int width, int height)
        {
            var roverFactory = new Domain.Factories.TaskFactory();

            var area = roverFactory.CreateArea(statement);
            area.Width.Should().Be(width);
            area.Height.Should().Be(height);
        }

    }
}
