using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class OperationDetails
    {
        public OperationDetails(bool operationResult, string message, string errorProperties)
        {
            Succedeed = operationResult;
            Message = message;
            Property = errorProperties;
        }
        public bool Succedeed { get; private set; }
        public string Message { get; private set; }
        public string Property { get; private set; }
    }
}
