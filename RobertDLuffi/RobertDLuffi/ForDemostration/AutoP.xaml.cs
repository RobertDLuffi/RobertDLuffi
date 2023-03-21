using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RobertDLuffi.ForDemostration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AutoP : ContentPage
	{
		public AutoP (string a1, string a2)
		{
			InitializeComponent ();
            lg.Text = a2;
            us_name.Text = a1;
		}

        private async void b1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SMP());
        }

        private async void b2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SKP(""));
        }
    }
}