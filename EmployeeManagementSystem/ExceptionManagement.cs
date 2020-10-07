using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{

    [Serializable]
    public class InputException : Exception
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public InputException() { }
        public InputException(string message) : base(message) { }
        protected InputException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public InputException(string message, DateTime time)
        {
            messageDetails = message;
            ErrorTimeStamp = time;
        }
        // Override the Exception.Message property.
        public override string Message => $"Input Error Message: {messageDetails} at {ErrorTimeStamp}";
    }
}
