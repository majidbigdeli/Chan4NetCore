﻿using System;

namespace Chan4NetCore.Helpers
{
    internal static class ChanUtility
    {
        public static void AssertChanNotClosed<T>(IChan<T> chan)
        {
            if (chan.IsClosed) throw new InvalidOperationException("The chan has been closed");
        }
    }
}