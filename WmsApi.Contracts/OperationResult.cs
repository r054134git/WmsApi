using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi
{
    public class OperationResult
    {
        public bool Success { get; set; }

        public string Description { get; set; }

        public OperationResult(bool success, string description)
        {
            Success = success;
            Description = description;
        }
    }
    public class OperationResult<T>
    {
        public bool Success { get; set; }

        public string Description { get; set; }

        public T Data { get; set; }
        public OperationResult(bool success, string description, T data)
        {
            Success = success;
            Description = description;
            Data = data;
        }
    }
}
