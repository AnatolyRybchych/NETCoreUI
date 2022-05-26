using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core.WindowEvents
{
    public delegate void MouseEnterHandler(object sender, IEnvironment environment, MouseEnterEventArgs e);

    public class MouseEnterEventArgs:EventArgs
    {
        public MouseEnterEventArgs()
        {

        }
    }
}
