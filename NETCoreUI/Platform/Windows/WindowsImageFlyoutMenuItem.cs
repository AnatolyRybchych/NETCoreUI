using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows
{
    public class WindowsImageFlyoutMenuItem
    {
        public WindowsImageFlyoutMenuItem()
        {
            TargetType = typeof(WindowsImageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}