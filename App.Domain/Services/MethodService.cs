using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;
using App.Domain.Interfaces.Services;

// author: Ruel B. Sucgang (.net software developer)

namespace App.Domain.Services
{
    public class MethodService : iMethodService
    {

        // create a constructor for the repository
        readonly iMethodRepository _methodRepository;
        public MethodService(iMethodRepository methodRepository) => 
            _methodRepository = methodRepository;

        // return the comparison validation result
        public string RegisterNewCompare(MethodEn obj1, MethodEn obj2)
        {
            return _methodRepository.CompareObjects(obj1,obj2);
        }

        // return identical
        public List<ListProperties> RegisterNewIdentitical(List<MethodEn> obj1, List<MethodEn> obj2)
        {
            return _methodRepository.GetDuplicates(obj1, obj2);
        }
    }
}
