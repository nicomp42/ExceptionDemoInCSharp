using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
    /// <summary>
    /// Event Logger
    /// </summary>
    class Logger
    {
        public void LogEvent(Error error)
        {
            // todo Implement this
            throw new Exception("Logger.log(): Not implemented");
            // Open the Event Log form
            // Send the error object to the Log Form
        }
        public static void WriteToEventLog(Error error)
        {
//          https://stackoverflow.com/questions/25725151/write-to-windows-application-event-log-without-registering-an-event-source
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(error.ToString(), EventLogEntryType.Information, 101, 1);
            }
        }
    }
}
