using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.Shared.Responses
{
    public class ActionResponse <T>
    {
        public bool WasSuccess { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }



    }
}
