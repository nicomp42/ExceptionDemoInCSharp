using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
    /// <summary>
    /// When catching exceptions list the catch blocks from specific to general.
    /// </summary>
    class OrderOfCatchBlocks
    {
        private void demo()
        {
            // This is correct
            try
            {

            }
            catch (IndexOutOfRangeException ex) { }
            catch (OutOfMemoryException ex) { }
            catch (Exception ex) { }
            finally
            {

            }
        }
        /// <summary>
        /// This will not build. The order of the exceptions is incorrect
        /// </summary>
        private void FailedDemo()
        {
            try
            {

            }
            catch (Exception ex) { }
            catch (OutOfMemoryException ex) { }
            catch (IndexOutOfRangeException ex) { }
            finally
            {

            }
        }
    }
}
