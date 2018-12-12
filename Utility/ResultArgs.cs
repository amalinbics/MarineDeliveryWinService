using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Utility
{
    public class ResultArgs
    {
        public bool Success { get; set; }
        public int AffectedRows { get; set; }
        public DataTable Source { get; set; }
        public string Message { get; set; }
        public object Scalar { get; set; }

    }
}
