using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class SzybkoscException : Exception
    {
        public SzybkoscException() { }
        public SzybkoscException(string message) : base(message) { }
        public SzybkoscException(string message, Exception inner) : base(message, inner) { }
        protected SzybkoscException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

