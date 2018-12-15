using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;
using App.Domain.Services;

namespace App.Petsure.Data
{
    public class FibonacciRepository: IFibonacciRepository
    {
        // Fibonacci sequence 
        public int Compute(int obj)
        {
            int first = 1;
            int second = 1;
            int sum = 0;

            while (sum <= obj)
            {
                sum = first + second;
                first = second;
                second = sum;
            }
            return sum;
        }

        //Fibonacci sequence iterative (for even)
        public int FibonacciIterative(int intParam)
        {
            int intFn1 = 1;
            int intFn2 = 1;

            for (int i = 3; i <= intParam; i++)
            {
                int intFn3 = intFn2;
                intFn1 = intFn2 + intFn1;
                intFn2 = intFn3;
            }
            return intFn1;
        }

        //Fibonacci sequence recursive (for odd)
        public int FibonacciRecursive(int intParam)
        {
            if (intParam == 1 || intParam == 2)
            {
                return 1;
            }
            else
                return FibonacciRecursive(intParam - 2) + FibonacciRecursive(intParam - 1);
        }

    }
}
