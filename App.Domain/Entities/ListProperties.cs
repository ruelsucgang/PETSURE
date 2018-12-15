using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// author: Ruel B. Sucgang (.net software developer)
namespace App.Domain.Entities
{
    public class ListProperties
    {
        public readonly string _paramname;
        public readonly string _paramvalue;
        public readonly string _paramtype;
        // constructor
        public ListProperties(string paramname,string paramvalue,string paramtype)
        {
            this._paramname = paramname;
            this._paramvalue = paramvalue;
            this._paramtype = paramtype;
        }


    }
}
