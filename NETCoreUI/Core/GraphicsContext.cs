using NETCoreUI.Core.Primitives;
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
        private ISimpleRenderer? simpleRenderer;
        public  ISimpleRenderer SimpleRenderer
        {
            get
            {
                if(simpleRenderer == null)
                    simpleRenderer = CreateSimpleRenderer();
                return simpleRenderer;
            }
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

        protected abstract ISimpleRenderer CreateSimpleRenderer();
        public interface ISimpleRenderer
        {
            public void FillAliasedRect(Color color, Rect rect);
            public void FillAliasedCircle(Color color, Rect bounds);
        }

        protected abstract IOpenGlContext CreateGlContext();
        public interface IOpenGlContext
        {
            public void MakeCurrent();
            public void SwapBuffers();
        }
    }
}
