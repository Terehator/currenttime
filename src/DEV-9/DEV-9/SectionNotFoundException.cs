using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DEV_9
{
    [Serializable()]
    class SectionNotFoundException : ApplicationException
    {
        public SectionNotFoundException() { }

        public SectionNotFoundException(string message) : base(message) { }

        public SectionNotFoundException(string message, Exception inner) : base(message, inner) { }

        protected SectionNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
