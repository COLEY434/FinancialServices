using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Core.DTOs.Response
{
    public class BadRequestResponseDto : BaseResponse
    {
        public List<string> Errors { get; set; }
    }
}
