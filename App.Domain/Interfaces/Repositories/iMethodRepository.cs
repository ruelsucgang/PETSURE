using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
// author: Ruel B. Sucgang (.net software developer)

namespace App.Domain.Interfaces.Repositories
{
    public interface iMethodRepository
    {
        string CompareObjects(MethodEn obj1, MethodEn obj2);

        List<ListProperties> GetDuplicates(List<MethodEn> obj1, List<MethodEn> obj2);
 
    }
}
