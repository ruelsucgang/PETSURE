using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using App.Domain.Entities;
// author: Ruel B. Sucgang (.net software developer)
namespace App.Domain.Interfaces.Repositories
{
    public interface IFibonacciRepository
    {
        int Compute(int obj);

        int FibonacciRecursive(int obj);

        int FibonacciIterative(int obj);

    }



}
