using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class PrzezroczystoscException : Exception
    {
        public PrzezroczystoscException() { }
        public PrzezroczystoscException(string message) : base(message) { }
        public PrzezroczystoscException(string message, Exception inner) : base(message, inner) { }
        protected PrzezroczystoscException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

