using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Services
{
   public interface IFibonacciService
    {
        int RegisterNewFiboncacci(int obj);
        int RegisterNewFiboncacciRecursive(int obj);
        int RegisterNewFiboncacciIterative(int obj);
    }
}
