using System;
using System.Collections.Generic;
using System.Text;

namespace WmsApi.Contracts.Models
{
    public class ResultModel
    {
        public bool IsSucceed { get; set; }

        public string Message { get; set; }

        public string Result { get; set; }
    }
    public class ResultModel<T>
    {
        public bool IsSucceed { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }
    }
}
