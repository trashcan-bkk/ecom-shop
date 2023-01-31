using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Identity;

namespace Core.Interfaces
{
    public interface ITokenService
    {
       string CreateToken(AppUser user);
    }
}