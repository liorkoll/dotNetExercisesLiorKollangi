﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomAwaiter
{
    static class MyExtensions
    {
        public static TaskAwaiter GetAwaiter(this TimeSpan timeSpan)
        {
            return Task.Delay(timeSpan).GetAwaiter();
        }

        public static TaskAwaiter GetAwaiter(this int miliseconds)
        {
            return TimeSpan.FromMilliseconds(miliseconds).GetAwaiter();
        }


        public static TaskAwaiter<int> GetAwaiter(this Process process)
        {
            var tcs = new TaskCompletionSource<int>();
            process.EnableRaisingEvents = true;
            process.Exited += (s, e) => tcs.TrySetResult(process.ExitCode);
            if (process.HasExited) tcs.TrySetResult(process.ExitCode);
            return tcs.Task.GetAwaiter();

        }
    }
}
