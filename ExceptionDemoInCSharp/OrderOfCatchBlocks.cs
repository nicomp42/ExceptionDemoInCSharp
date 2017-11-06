using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoInCSharp
{
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
