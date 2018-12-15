using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Interfaces.Entities;
// author: Ruel B. Sucgang (.net software developer)

namespace App.Domain.Entities
{
    public class PropetiesEn : iPropetiesEn
    {
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public string ParameterType { get; set; }
    }
}
