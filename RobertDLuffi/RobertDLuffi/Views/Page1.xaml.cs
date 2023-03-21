using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Common.ReedSolomon;
using static Xamarin.Essentials.Permissions;

namespace RobertDLuffi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{

        public Class1 s;
        ItemsViewModel _viewModel;
        public Page1()
        {
            InitializeComponent();
            s = new Class1();
            BindingContext = _viewModel = new ItemsViewModel();
            scan.Text = s.res_scan;
        }
        public Page1(string a)
        {
            InitializeComponent();
            scan.Text = a;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
           
        }






        private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (label != null)
                label.Text = "Дата " + e.NewDate.ToString("dd/MM/yyyy");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ppp());
            
        }

        private void scan_Completed(object sender, EventArgs e)
        {
            
        }
    }
}