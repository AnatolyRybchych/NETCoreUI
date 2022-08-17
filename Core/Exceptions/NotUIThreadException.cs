using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.Exceptions
{
    public class NotUIThreadException : Exception
    {
        public NotUIThreadException(string message):base($"this method can be called only from UI thread, {message}")
        {
        }

        public NotUIThreadException() : base("this method can be called only from UI thread")
        {
        }
    }
}
