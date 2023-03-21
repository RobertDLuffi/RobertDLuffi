using RobertDLuffi.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;

namespace RobertDLuffi.ForDemostration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SKP : ContentPage
    {
        public static string res;
        
        public SKP(string a)
        {
            InitializeComponent();
            scan.Text = a;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ppp());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SMP());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AutoP(CConection.us_name, CConection.us_login));
        }
    }
}