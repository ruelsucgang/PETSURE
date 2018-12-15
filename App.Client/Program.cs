using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Interfaces.Repositories;
using App.Domain.Interfaces.Services;
using App.Petsure.Data;
using App.Domain.Entities;
using App.Domain.Services;
using System.Security.Cryptography;

// author: Ruel B. Sucgang (.net software developer)
namespace App.Client 
{
    public class Program
    {
        static void Main(string[] args)
        {

            // check the first method (comparison of 2 objeect's type)
            GetComparison();

            // check the second method
            GetDuplicates();

            // check the third method
            GetHash();

            // fibonacci sequence
            Fibonacci();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        private static void GetComparison()
        {
            try
            {
                //create an instance of the service
                iMethodService methodService = new MethodService(new MethodRepository());

                //initialize sample values of the entity
                var en1 = new MethodEn()
                {
                    Param1 = 999
                };
                var en2 = new MethodEn()
                {
                    Param1 = true
                };

                string strResult = string.Empty;
                strResult = "METHOD 1" + System.Environment.NewLine;
                strResult += methodService.RegisterNewCompare(en1, en2);

                // To test the Service, Display the parameter's value and data type 
                Console.WriteLine(strResult);
               // Console.ReadKey();
            }
            catch ( Exception)
            {
            }
        }

        private static void GetDuplicates()
        {
            try
            {
                //create an instance of the service
                iMethodService methodService = new MethodService(new MethodRepository());

                //initialize sample values of the entity
                List<MethodEn> en1 = new List<MethodEn>();
                List<MethodEn> en2 = new List<MethodEn>();

                en1.Add(new MethodEn { Param1 = "aaa" });
                en1.Add(new MethodEn { Param1 = "bbb" });
                en1.Add(new MethodEn { Param1 = "ccc" });
                en1.Add(new MethodEn { Param1 = "999" });
                en1.Add(new MethodEn { Param1 = "yyy" });
                en1.Add(new MethodEn { Param1 = "zzz" });

                en2.Add(new MethodEn { Param1 = "bbb" }); //duplicate
                en2.Add(new MethodEn { Param1 = "111" });
                en1.Add(new MethodEn { Param1 = "ccc" }); //duplicate
                en2.Add(new MethodEn { Param1 = "xyz" });
                en2.Add(new MethodEn { Param1 = "999" }); //duplicate
                en2.Add(new MethodEn { Param1 = "053" });

                // this is the list of duplicates
                List<ListProperties> en3 = new List<ListProperties>();
                en3 = methodService.RegisterNewIdentitical(en1, en2);

                // Append records into stringbuilder 
                StringBuilder sb = new StringBuilder();
                sb.Append("METHOD 2");
                sb.Append(System.Environment.NewLine);
                foreach (var item in en3)
                {
                    sb.Append("  Param Name: " + item._paramname);
                    sb.Append("  Param Value: " + item._paramvalue);
                    sb.Append(System.Environment.NewLine);
                }
                // Display the duplcates 
                Console.WriteLine(sb);
                //Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static void GetHash()
        {
            try
            {

                iCryptographyService methodService = new CryptographyHashService(new CryptographyRepository());

                UsersEn obj = new UsersEn();
                obj.Passwrd = "ruel sucgang";
                obj.Passwrd = methodService.RegisterNewCryptographyHash(SHA1.Create(), obj);


                // Display the encrypted password (in json format)
                string strResult = "METHOD 3" + System.Environment.NewLine;
                Console.WriteLine(strResult + obj.Passwrd);
                //Console.ReadKey();
            }
            catch (Exception)
            {
            }
        }

        private static void Fibonacci()
        {
            try
            {
                //create an instance of the service
                IFibonacciService methodService = new FibonacciService(new FibonacciRepository());

                //initialize sample parameter value
                int intParam = 0; int intResult = 0;
                intParam = 6;

                //execute fibonacci
                intResult = FibonacciSequence(intParam);

                string strN = System.Environment.NewLine;
                Console.WriteLine(strN + "FIBONACCI" + strN + "Compute Result: " + intResult.ToString());

                //check if othe result is an odd or even 
                int intNum = 0;
                strN = "Result is an ";
                if (intResult % 2 == 0) // for even number result
                {
                    intNum = FibonacciIterative(intResult);
                    Console.WriteLine(strN + "Even number " + intNum.ToString()) ;  
                }
                else                    // for odd number result
                {
                    intNum = FiboncacciRecursive(intResult);
                    Console.WriteLine(strN + "Odd number " + intNum.ToString());
                }
                //Console.ReadKey();
            }
            catch (Exception)
            {
            }
        }


        private static int FibonacciSequence(int intParam)
        {
            try
            {
                //create an instance of the service
                IFibonacciService methodService = new FibonacciService(new FibonacciRepository());

                //initialize sample parameter value
                int intResult = 0;

                //execute fibonacci
                intResult = methodService.RegisterNewFiboncacci(intParam);

                //result
                return intResult;

            }
            catch (Exception)
            {
                return 0;
            }
         }

        private static int FibonacciIterative(int intParam)
        {
            try
            {
                //create an instance of the service
                IFibonacciService methodService = new FibonacciService(new FibonacciRepository());

                //initialize sample parameter value
                int intResult = 0;

                //execute fibonacci
                intResult = methodService.RegisterNewFiboncacciIterative(intParam);

                //result
                return intResult;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private static int FiboncacciRecursive(int intParam)
        {
            try
            {
                //create an instance of the service
                IFibonacciService methodService = new FibonacciService(new FibonacciRepository());

                //initialize sample parameter value
                int intResult = 0;

                //execute fibonacci
                intResult = methodService.RegisterNewFiboncacciRecursive(intParam);

                //result
                return intResult;
            }
            catch (Exception)
            {
                return 0;
            }
           
        }
    }
}
