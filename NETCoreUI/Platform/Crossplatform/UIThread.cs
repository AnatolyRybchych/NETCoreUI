using NETCoreUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreUI.Platform.Crossplatform
{
    public abstract class UIThread : IUIThread
    {
        private Thread thread;
        private bool isRunning;

        private Queue<Action> actionsQueue;
        private Queue<Action> backActionsQueue;
        private object queueLocker;

        public void Execute(Action action)
        {
            lock (queueLocker)
                backActionsQueue.Enqueue(action);
        }

        public void Join()
        {
            thread.Join();
        }

        public UIThread()
        {
            queueLocker = new object();
            actionsQueue = new Queue<Action>();
            backActionsQueue = new Queue<Action>();
            isRunning = true;

            thread = new Thread(() =>
            {
                while (isRunning)
                {
                    if (ReceiveMessages())
                        if (HandleMessages())
                            isRunning = false;

                    SwapActionQueues();
                    Action? action;
                    while (actionsQueue.TryDequeue(out action))
                        action?.Invoke();
                }
            });

            thread.Start();
        }

        private void SwapActionQueues()
        {
            Queue<Action> tmp = actionsQueue;
            actionsQueue = backActionsQueue;
            backActionsQueue = tmp;
        }

        //returns true if required to handle
        protected abstract bool ReceiveMessages();
        //returns false if reuired to close thread
        protected abstract bool HandleMessages();
    }
}
