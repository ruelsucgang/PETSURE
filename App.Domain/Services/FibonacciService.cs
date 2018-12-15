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
    public class FibonacciService: IFibonacciService
    {

        // create a constructor for the repository
        readonly IFibonacciRepository _methodRepository;
        public FibonacciService(IFibonacciRepository methodRepository) =>
          _methodRepository = methodRepository;

        //Fibonacci sequence (the result of this will be used either for recursive or iterative)
        public int RegisterNewFiboncacci(int obj)
        {
            return _methodRepository.Compute(obj) ;
        }

        //Fibonacci sequence iterative (for even)
        public int RegisterNewFiboncacciIterative(int obj)
        {
            return _methodRepository.FibonacciIterative(obj);
        }

        //Fibonacci sequence recursive (for odd)
        public int RegisterNewFiboncacciRecursive(int obj)
        {
            return _methodRepository.FibonacciRecursive(obj);
        }

    }
}
