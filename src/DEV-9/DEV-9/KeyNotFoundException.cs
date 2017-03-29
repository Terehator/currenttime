﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    [Serializable()]
    class KeyNotFoundException : ApplicationException
    {
        public KeyNotFoundException() { }

        public KeyNotFoundException(string message) : base(message) { }

        public KeyNotFoundException(string message, Exception inner) : base(message, inner) { }

        protected KeyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
