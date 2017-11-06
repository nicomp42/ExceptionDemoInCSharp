using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
    /// <summary>
    /// The Exception thrown when an Error object encounters an invalid error message
    /// </summary>
    class ErrorMessageException :Exception
    {
        public ErrorMessageException(String message) : base (message)
        {}
    }
}
