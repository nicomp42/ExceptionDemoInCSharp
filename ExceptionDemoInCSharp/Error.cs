using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
    /// <summary>
    /// Error Object
    /// </summary>
    class Error
    {
        private String message { get; set; }
        public Error(String message)
        {
            this.message = message;
        }
        public override String ToString() { return message; }
    }
}
