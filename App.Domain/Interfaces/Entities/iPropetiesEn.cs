using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace App.Domain.Interfaces.Entities
{
    public interface iPropetiesEn
    {
        string ParameterName { get; set; }
        string ParameterValue { get; set;  }
        string ParameterType { get; set; }
    }
}
