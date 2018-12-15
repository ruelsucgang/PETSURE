using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using System.Security.Cryptography;
// author: Ruel B. Sucgang (.net software developer)

namespace App.Domain.Interfaces.Services
{
    public interface iMethodService
    {
        string RegisterNewCompare(MethodEn obj1, MethodEn obj2);

        List<ListProperties> RegisterNewIdentitical(List<MethodEn> obj1, List<MethodEn> obj2) ;

       }
}
