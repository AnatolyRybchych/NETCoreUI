using NETCoreUI.Core.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public interface IGraphicsImage
    {
        GraphicsContext Graphics { get; }
        Size Size { get; }
    }
}
