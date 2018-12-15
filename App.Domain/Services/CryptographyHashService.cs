using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;
using App.Domain.Interfaces.Services;

using App.Domain.Entities;
using System.Web.Script.Serialization;

// author: Ruel B. Sucgang (.net software developer)
namespace App.Domain.Services
{
    public class CryptographyHashService: iCryptographyService
    {

        // create a constructor for the repository
        readonly iCryptographyRepository _methodRepository;
        public CryptographyHashService(iCryptographyRepository methodRepository) =>
            _methodRepository = methodRepository;

   
        public string RegisterNewCryptographyHash(HashAlgorithm algorithm, UsersEn obj)
        {
            return _methodRepository.GetBase64Hash(algorithm, obj);
        }
    }
}
