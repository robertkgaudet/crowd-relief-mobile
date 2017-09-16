using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdRelief.Interfaces
{
    public interface ILoginService
    {
        Task LoginAsync(string provider);
        Task LogOut();
        Task StoreToken(string token);
        Task GetToken();
        Task CheckToken();
    }
}
