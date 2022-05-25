using NETCoreUI.Platform.Linux;
using NETCoreUI.Platform.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Core
{
    public abstract class GraphicsContext
    {
        public static GraphicsContext FromWindow(IWIndow window)
        {
            GraphicsContext? result = null;
            EnvironmentProvider.SplitActionsByEnvironments((linux) =>
            {
                LinuxWindow wnd = window.ToLinux();
                result = new LinuxGraphicsContext(wnd.LinuxEnvironamnt.Display, wnd.XID);
            }, (windows) =>
            {
                NTWindow wnd = window.ToWindows();
                result = new WindowsGraphicsContext(wnd.HWindow);
            });
            if (result == null) throw new Exception("cannot create graphics context");
            return result;
        }

        private IOpenGlContext? glContext = null;
        public IOpenGlContext GlContext
        {
            get
            {
                if (glContext == null)
                    glContext = CreateGlContext();
                return glContext;
            }
        }


        protected abstract IOpenGlContext CreateGlContext();

        public interface IOpenGlContext
        {
            public void MakeCurrent();
            public void SwapBuffers();
        }

    }
}
