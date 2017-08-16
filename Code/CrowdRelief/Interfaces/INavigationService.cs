using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdRelief.Interfaces
{
    public interface INavigationService
    {
        void NavigateToRoot<TViewModel>(bool hasNavigationPage, object data = null) where TViewModel : class, IViewModel;
        Task NavigateToAsync<TViewModel>(object data = null) where TViewModel : class, IViewModel;
    }
}
