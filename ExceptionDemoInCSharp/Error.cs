/***********************************************
 * There is a flaw in the design of this class
 * *********************************************/
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
        private String mMessage;
        private String message
        {
            get { return mMessage; }
            set {
                // Throw an exception if the message is blank and do not store the message
                if (value.Trim().Length == 0) { throw new ErrorMessageException("message length cannot be zero"); }
                mMessage = value;
            }
        }
        public Error(String message)
        {
            this.message = message;
        }
        public override String ToString() { return message; }
    }
}
