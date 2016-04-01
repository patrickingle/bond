﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Bond.Examples.Logging
{
    using System;

    using Bond.Comm;

    public class ConsoleLogger : LogHandler
    {
        public void Handle(LogSeverity severity, string message, Exception exception = null)
        {
            // This example logs everything. You may want to drop messages above LogSeverity.Debug.
            Console.WriteLine($"[bond] {severity.ToString().ToUpper()}: {message}");
            if (exception != null)
            {
                Console.Write(exception);
            }
        }
    }
}
