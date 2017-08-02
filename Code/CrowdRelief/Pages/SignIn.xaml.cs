using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrowdRelief.Pages {
	public partial class SignIn : ContentPage {
		public SignIn() {
			InitializeComponent();
        }
        public void MoreButton_Clicked(object sender, EventArgs e)
        {

            FirstStackLayout.IsVisible = !FirstStackLayout.IsVisible;
            SecondStackLayout.IsVisible = !SecondStackLayout.IsVisible;
        }
    }
}
