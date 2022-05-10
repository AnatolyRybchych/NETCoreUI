using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Windows.Win32.Types
{
    public enum PM : UInt32
    {
        NOREMOVE = 0x0000,
        REMOVE = 0x0001,
        NOYIELD = 0x0002,

        QS_INPUT = QS.INPUT << 16,
        QS_PAINT = QS.PAINT << 16,
        QS_POSTMESSAGE = QS.POSTMESSAGE << 16,
        QS_SENDMESSAGE = QS.SENDMESSAGE << 16,
    }
}
