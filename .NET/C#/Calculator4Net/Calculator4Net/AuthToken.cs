using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculator4Net
{
    public class AuthToken
    {
        public string Token { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}