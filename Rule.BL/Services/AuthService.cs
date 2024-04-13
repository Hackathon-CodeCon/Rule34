using Rule.BL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule.BL.Services;

public class AuthService : IAuthService
{
    public async Task<bool> IsAuthorize(string username, string password)
    {
        throw new NotImplementedException();
    }
}
