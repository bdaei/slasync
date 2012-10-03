using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net;

namespace ISMOT.WindowsPhone.Threading.Tasks
{
    public static class Async
    {
        public static Task<TResult> Invoke<TEventArgs, TResult>
            (Action act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, object, object, object, object>(
                new Action<object, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam>
            (Action<TParam> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam, object, object, object>(
                new Action<TParam, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2>
            (Action<TParam1, TParam2> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, object, object>(
                new Action<TParam1, TParam2, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, object>(
                new Action<TParam1, TParam2, TParam3, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4>(
                new Action<TParam1, TParam2, TParam3, TParam4>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, object serviceClient, string methodName, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            var serviceType = serviceClient.GetType();
            var completedEventName = methodName.Replace("Async", "Completed");
            var completedEvent = serviceType.GetEvent(completedEventName);

            var taskCompletion = new TaskCompletionSource<TResult>();
            var handler = new Action<AsyncCompletedEventArgs>((e) =>
            {
                if (e.Error != null)
                    taskCompletion.TrySetException(e.Error);
                else if (e.Cancelled)
                    taskCompletion.TrySetCanceled();
                else
                {
                    var argsType = e.GetType();
                    var resultProperty = argsType.GetProperty("Result");
                    taskCompletion.TrySetResult((TResult)resultProperty.GetValue(e, null));
                }
            });

            if (completedEvent.EventHandlerType.FullName == typeof(DownloadStringCompletedEventHandler).FullName)
            {
                completedEvent.AddEventHandler(serviceClient, new DownloadStringCompletedEventHandler((s, e) =>
                {
                    handler(e);
                }));
            }
            else
                completedEvent.AddEventHandler(serviceClient, new EventHandler<TEventArgs>((s, e) =>
                {
                    handler(e);
                }));

            for (int i = 0; i <= 3; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);

            return (taskCompletion.Task);
        }

        //No Return Value Invokers - With Custom EventArgs

        public static Task InvokeC<TEventArgs>
            (Action act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, object, object, object, object>(
                new Action<object, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam>
            (Action<TParam> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam, object, object, object>(
                new Action<TParam, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2>
            (Action<TParam1, TParam2> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, object, object>(
                new Action<TParam1, TParam2, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, object>(
                new Action<TParam1, TParam2, TParam3, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4>(
                new Action<TParam1, TParam2, TParam3, TParam4>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, object serviceClient, string methodName, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            var serviceType = serviceClient.GetType();
            var completedEventName = methodName.Replace("Async", "Completed");
            var completedEvent = serviceType.GetEvent(completedEventName);

            var taskCompletion = new TaskCompletionSource<object>();
            var handler = new Action<AsyncCompletedEventArgs>((e) =>
            {
                if (e.Error != null)
                    taskCompletion.TrySetException(e.Error);
                else if (e.Cancelled)
                    taskCompletion.TrySetCanceled();
                else
                {
                    taskCompletion.TrySetResult(null);
                }
            });

            if (completedEvent.EventHandlerType.FullName == typeof(DownloadStringCompletedEventHandler).FullName)
            {
                completedEvent.AddEventHandler(serviceClient, new DownloadStringCompletedEventHandler((s, e) =>
                {
                    handler(e);
                }));
            }
            else
                completedEvent.AddEventHandler(serviceClient, new EventHandler<TEventArgs>((s, e) =>
                {
                    handler(e);
                }));

            for (int i = 0; i <= 3; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);

            return (taskCompletion.Task);
        }

        //No Return Value Invokers - With Default EventArgs (AsyncCompletedEventArgs)

        public static Task Invoke
           (Action act, params object[] args)
        {
            return (Invoke<object, object, object, object>(
                new Action<object, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1>
           (Action<TParam1> act, params object[] args)
        {
            return (Invoke<TParam1, object, object, object>(
                new Action<TParam1, object, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2>
           (Action<TParam1, TParam2> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, object, object>(
                new Action<TParam1, TParam2, object, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, object>(
                new Action<TParam1, TParam2, TParam3, object>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4>(
                new Action<TParam1, TParam2, TParam3, TParam4>((p1, p2, p3, p4) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task Invoke<TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, object serviceClient, string methodName, params object[] args)
        {
            var serviceType = serviceClient.GetType();
            var completedEventName = methodName.Replace("Async", "Completed");
            var completedEvent = serviceType.GetEvent(completedEventName);

            var taskCompletion = new TaskCompletionSource<object>();
            var handler = new Action<AsyncCompletedEventArgs>((e) =>
            {
                if (e.Error != null)
                    taskCompletion.TrySetException(e.Error);
                else if (e.Cancelled)
                    taskCompletion.TrySetCanceled();
                else
                {
                    taskCompletion.TrySetResult(null);
                }
            });

            if (completedEvent.EventHandlerType.FullName == typeof(DownloadStringCompletedEventHandler).FullName)
            {
                completedEvent.AddEventHandler(serviceClient, new DownloadStringCompletedEventHandler((s, e) =>
                {
                    handler(e);
                }));
            }
            else
                completedEvent.AddEventHandler(serviceClient, new EventHandler<AsyncCompletedEventArgs>((s, e) =>
                {
                    handler(e);
                }));

            for (int i = 0; i <= 3; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);

            return (taskCompletion.Task);
        }
    }
}
