using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MyException: Exception
    {
        public MyException()
        {
            
        }

        public MyException(string message) : base(message)
        {
           
        }

        public MyException(string message, Exception inner) : base(message)
        {

        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            
        }
    }
}
