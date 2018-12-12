using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;
namespace QueryBase
{
    public interface IQueryFetch
    {       
        string GetQuery(object command);
    }
}
