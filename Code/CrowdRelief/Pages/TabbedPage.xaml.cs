using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrowdRelief.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrowdReliefTabbedPage : TabbedPage
    {
        public CrowdReliefTabbedPage()
        {
            InitializeComponent();

        }
    }
}