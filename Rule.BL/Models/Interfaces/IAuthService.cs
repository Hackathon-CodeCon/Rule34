using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule.BL.Models.Interfaces
{
    public interface IAuthService
    {
        Task<bool> IsAuthorize(string username, string password);
    }
}
