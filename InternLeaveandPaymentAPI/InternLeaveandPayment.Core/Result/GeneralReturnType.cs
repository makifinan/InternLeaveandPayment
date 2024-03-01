﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Core.Result
{
    public class GeneralReturnType<T>
    {
        public T Datas { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
