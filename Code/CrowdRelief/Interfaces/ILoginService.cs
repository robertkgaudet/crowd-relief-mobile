using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;

namespace CrowdRelief.Interfaces
{
    public interface ILoginService
    {
        Task LoginAsync(string provider);
        Task LogOut();
        Task StoreToken();
        Task GetToken();
        Task CheckToken();
    }
}
