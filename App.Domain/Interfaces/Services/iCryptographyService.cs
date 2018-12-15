using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.Domain.Entities;
using System.Security.Cryptography;
// author: Ruel B. Sucgang (.net software developer)

namespace App.Domain.Interfaces.Services
{
    public interface iCryptographyService
    {
        string RegisterNewCryptographyHash(HashAlgorithm algorithm, UsersEn obj);
    }
}
