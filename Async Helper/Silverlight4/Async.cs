using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ISMOT.Silverlight.Threading.Tasks
{
    public static class Async
    {
        public static Task<TResult> Invoke<TEventArgs, TResult>
            (Action act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, object, object, object, object, object, object, object, object>(
                new Action<object, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam>
            (Action<TParam> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam, object, object, object, object, object, object, object>(
                new Action<TParam, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2>
            (Action<TParam1, TParam2> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, object, object, object, object, object, object>(
                new Action<TParam1, TParam2, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, object, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task<TResult> Invoke<TEventArgs, TResult, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, object serviceClient, string methodName, params object[] args)
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

            for (int i = 0; i <= 7; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);

            return (taskCompletion.Task);
        }

        //No Return Value Invokers - With Custom EventArgs

        public static Task InvokeC<TEventArgs>
            (Action act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, object, object, object, object, object, object, object, object>(
                new Action<object, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam>
            (Action<TParam> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam, object, object, object, object, object, object, object>(
                new Action<TParam, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2>
            (Action<TParam1, TParam2> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, object, object, object, object, object, object>(
                new Action<TParam1, TParam2, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, object, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, params object[] args)
            where TEventArgs : AsyncCompletedEventArgs
        {
            return (InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task InvokeC<TEventArgs, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, object serviceClient, string methodName, params object[] args)
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

            for (int i = 0; i <= 7; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);

            return (taskCompletion.Task);
        }

        //No Return Value Invokers - With Default EventArgs (AsyncCompletedEventArgs)

        public static Task Invoke
           (Action act, params object[] args)
        {
            return (Invoke<object, object, object, object, object, object, object, object>(
                new Action<object, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke();
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1>
           (Action<TParam1> act, params object[] args)
        {
            return (Invoke<TParam1, object, object, object, object, object, object, object>(
                new Action<TParam1, object, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2>
           (Action<TParam1, TParam2> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, object, object, object, object, object, object>(
                new Action<TParam1, TParam2, object, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3>
            (Action<TParam1, TParam2, TParam3> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, object, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, object, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4>
            (Action<TParam1, TParam2, TParam3, TParam4> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4, object, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, object, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4, TParam5>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, object, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, object, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, object>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6]);
                }), act.Target, act.Method.Name, args));
        }

        public static Task Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, params object[] args)
        {
            return (Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(
                new Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>((p1, p2, p3, p4, p5, p6, p7, p8) =>
                {
                    act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                        (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);
                }), act.Target, act.Method.Name, args));
        }

        private static Task Invoke<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>
            (Action<TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> act, object serviceClient, string methodName, params object[] args)
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

            for (int i = 0; i <= 7; i++)
            {
                if (args.Length <= i)
                    Array.Resize<object>(ref args, args.Length + 1);
            }

            act.Invoke((TParam1)args[0], (TParam2)args[1], (TParam3)args[2], (TParam4)args[3],
                (TParam5)args[4], (TParam6)args[5], (TParam7)args[6], (TParam8)args[7]);

            return (taskCompletion.Task);
        }
    }
}
