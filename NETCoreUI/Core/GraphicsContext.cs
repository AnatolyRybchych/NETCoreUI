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
