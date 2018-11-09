using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.DomainModels
{
    public class Area
    {
        public Area(int width, int height)
        {

            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool IsCorrectLocation(Location location)
        {
            return location.X <= Width && location.Y <= Height;
        }

    }
}
