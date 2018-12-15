
using Microsoft.VisualStudio.TestTools.UnitTesting;


using App.Domain.Interfaces.Repositories;
using App.Domain.Interfaces.Services;
using App.Petsure.Data;
using App.Domain.Entities;
using App.Domain.Services;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

// author: Ruel B. Sucgang (.net software developer)

namespace App.Petsure.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
            string strActual = string.Empty;
            strActual = methodService.RegisterNewCompare(en1, en2);
            string strExpected =
              "Param1 Value is 999 Type is System.Int32 \r\nParam1 Value is True Type is System.Boolean \r\n";
            Assert.AreEqual(strExpected, strActual);
        }

        [TestMethod]
        public void TestMethod2()
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


            //count all duplicates
            int intActual = 0; int intExpected=0;
            intActual = en3.Count;
            intExpected = 3;

            Assert.AreEqual(intExpected, intActual);

        }


        // for this test: you need to install the newtonjson(from nuget)
        [TestMethod]
        public void TestMethod3()
        {
            iCryptographyService methodService = new CryptographyHashService(new CryptographyRepository());
            UsersEn obj = new UsersEn();
            obj.Passwrd = "ruel sucgang";

            string strActual = string.Empty;
            string strExpected = "{\"Passwrd\":\"IFXWrxuf7eodJ863QAmbwjDYALE=\"}";
            strActual  = methodService.RegisterNewCryptographyHash(SHA1.Create(), obj);

            Assert.AreEqual(strExpected, strActual);
  
        }

        // for the Fibonacci sequence
        [TestMethod]
        public void TestMethod4()
        {
            //create an instance of the service
            IFibonacciService methodService = new FibonacciService(new FibonacciRepository());

            //initialize sample parameter value
            int intExpected = 0; int intActual = 0;
            int intParam = 6;

            //execute fibonacci
            intActual = methodService.RegisterNewFiboncacci(intParam);
            intExpected = 8;

            Assert.AreEqual(intExpected, intActual);

        }


        // for the Fibonacci recursive   
        [TestMethod]
        public void TestMethod5()
        {
            //create an instance of the service
            IFibonacciService methodService = new FibonacciService(new FibonacciRepository());


            //initialize sample parameter value
            int intExpected = 233; int intActual = 0;
            int intParam = 13;

            //execute fibonacci
            intActual = methodService.RegisterNewFiboncacciRecursive(intParam);

       
            Assert.AreEqual(intExpected, intActual);

        }

        // for the Fibonacci iterative    
        [TestMethod]
        public void TestMethod6()
        {
            //create an instance of the service
            IFibonacciService methodService = new FibonacciService(new FibonacciRepository());


            //initialize sample parameter value
            int intExpected = 7; int intActual = 0;
            int intParam = 8;

            //execute fibonacci
            intActual = methodService.RegisterNewFiboncacciIterative(intParam);


            Assert.AreEqual(intExpected, intActual);

        }

    }
}
