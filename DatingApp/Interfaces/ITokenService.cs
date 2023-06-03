using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Models;

namespace DatingApp.Interfaces
{
    public interface ITokenService
    {
         public string CreateToken(AppUser appUser);
    }
}