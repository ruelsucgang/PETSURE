using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: Ruel B. Sucgang (.net software developer)
namespace App.Domain.Entities
{
    public class ListParam
    {

        public readonly object _paramname;
        // constructor
        public ListParam(object paramname)
        {
            this._paramname = paramname;
        }

    }
}
