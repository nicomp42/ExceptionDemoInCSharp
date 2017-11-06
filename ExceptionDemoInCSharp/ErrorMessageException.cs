using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
    class ErrorMessageException :Exception
    {
        public ErrorMessageException(String message) : base (message)
        {}
    }
}
