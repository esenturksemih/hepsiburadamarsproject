using MarsProjectEsenturk.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            Area area = null;
            Rover rover = null;

            Domain.Factories.TaskFactory taskFactory = new Domain.Factories.TaskFactory();


            while (true)
            {
                var statement = Console.ReadLine().Trim().ToUpper();

                if (statement == string.Empty)
                {
                    break;
                }

                if (area == null)
                {
                    area = taskFactory.CreateArea(statement);
                }
                else if (rover == null)
                {
                    rover = taskFactory.CreateRover(area, statement);
                }
                else
                {
                    rover.Process(statement);
                    Console.WriteLine(rover);
                    rover = null;
                }
            }
        }
    }
}
