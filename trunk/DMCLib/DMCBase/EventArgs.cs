﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMCBase
{
    public class EventArgs<T> : EventArgs
    {
        public T Value { get; private set; }

        public EventArgs(T value)
        {
            this.Value = value;
        }
    }
}
