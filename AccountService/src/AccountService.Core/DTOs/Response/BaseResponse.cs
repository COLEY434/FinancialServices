﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Core.DTOs.Response
{
    public class BaseResponse
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
