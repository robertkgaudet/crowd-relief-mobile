using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrowdRelief.Pages
{
    public partial class CrowdReliefNavigationPage : NavigationPage
    {
        public CrowdReliefNavigationPage(ContentPage streamPage) : base (streamPage)
        {
            InitializeComponent();
        }
    }
}