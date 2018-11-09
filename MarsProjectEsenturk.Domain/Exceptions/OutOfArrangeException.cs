using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectEsenturk.Domain.Exceptions
{
    class OutOfArrangeException : System.Exception
    {
        public override string Message => "Out of Arrange..!";
    }
}
