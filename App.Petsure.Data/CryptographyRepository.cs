using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;
using App.Domain.Services;


namespace App.Petsure.Data
{
    public class CryptographyRepository : iCryptographyRepository
    {
        public string GetBase64Hash(HashAlgorithm algorithm, UsersEn obj)
        {
            byte[] input = UnicodeEncoding.Unicode.GetBytes(obj.Passwrd);
            obj.Passwrd = Convert.ToBase64String(Hash(algorithm, input));
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return json;
        }

        private byte[] Hash(HashAlgorithm algorithm, byte[] input)
        {
            return algorithm.ComputeHash(input);
        }



    }
}
