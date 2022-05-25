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

        public UIThread(IEnvironment environment)
        {
            Environment = environment;
            queueLocker = new object();
            actionsQueue = new Queue<Action>();
            backActionsQueue = new Queue<Action>();
            isRunning = true;

            thread = new Thread(() =>
            {
                while (isRunning)
                {
                    ReceiveMessages();
                    Thread.Sleep(MsTimeout);
                }
            });
        }

        public bool IsCurrentThread => thread == Thread.CurrentThread;

        public IEnvironment Environment { get; private set; }

        public void Start() => thread.Start();
        public void Join() => thread.Join();
        public void Stop() => isRunning = false;

        public int MsTimeout = 2;

        public void Execute(Action action)
        {
            lock (queueLocker)
                backActionsQueue.Enqueue(action);
        }

        public void HandleActions()
        {
            SwapActionQueues();
            Action? action;
            while (actionsQueue.TryDequeue(out action))
                action?.Invoke();
        }

        private void SwapActionQueues()
        {
            Queue<Action> tmp = actionsQueue;
            actionsQueue = backActionsQueue;
            backActionsQueue = tmp;
        }

        protected abstract void ReceiveMessages();
    }
}
