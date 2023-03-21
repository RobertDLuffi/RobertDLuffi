using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using ZXing;
using RobertDLuffi.ForDemostration;

namespace RobertDLuffi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ppp : ZXingScannerPage
    {
        public string a;

        public Class1 s;
        
        public ppp()
        {
            InitializeComponent();
            s= new Class1();
            
        }

        public void Handle_OnScanResult( Result result)
        {
            
            Device.BeginInvokeOnMainThread(async () =>
            {
                a = result.Text;
                
                s.res_scan = a;
                await DisplayAlert("Scanned result", a, "OK");
                await Navigation.PushAsync(new SKP(a));
                

            });

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            IsScanning = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            IsScanning = false;
        }
    }
}