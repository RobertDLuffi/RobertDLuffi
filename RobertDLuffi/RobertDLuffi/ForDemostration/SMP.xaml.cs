using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Common;
using ZXing;
using ZXing.Net.Mobile.Forms;
using Xamarin.Essentials;
using static System.Net.Mime.MediaTypeNames;
using ZXing.QrCode;
using System.Drawing;
using ZXing.PDF417.Internal;

namespace RobertDLuffi.ForDemostration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SMP : ContentPage
	{
        //=----------ДЛЯ ШК--------------
        public  string a1;
        public string a2;
        public string a3;


        //----------------ДЛЯ АДРЕСОВ--------------

        public string b1;
        public string b2;
        public string b3;


        public static int i;

        public SMP ()
		{
			InitializeComponent ();
		}
        private void picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (picker2.SelectedIndex == 0)
            {
                a2 = "01";
                b2 = "43";
                CConection.p2 = 43;

            }
            if (picker2.SelectedIndex == 1)
            {
                a2 = "02";
                b2 = "12";
                CConection.p2 = 12;
            }
            if (picker2.SelectedIndex == 2)
            {
                a2 = "03";
                b2 = "53";
                CConection.p2 = 53;
            }
            if (picker2.SelectedIndex == 3)
            {
                a2 = "04";
                b2 = "31";
                CConection.p2 = 31;
            }
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (picker1.SelectedIndex == 0)
            {
                a1 = "12";
                b1 = "43";
                CConection.p1 = 43;
            }
            if (picker1.SelectedIndex == 1)
            {
                a1 = "13";
                b1 = "12";
                CConection.p1 = 12;
            }
            if (picker1.SelectedIndex == 2)
            {
                a1 = "14";
                b1 = "53";
                CConection.p1 = 53;
            }
            if (picker1.SelectedIndex == 3)
            {
                a1 = "15";
                b1 = "32";
                CConection.p1 = 32;
            }
        }

        private void picker3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (picker3.SelectedIndex == 0)
            {
                a3 = "22";
                b3 = "1";
                CConection.type = 1;


            }
            if (picker3.SelectedIndex == 1)
            {
                a3 = "21";
                b3 = "2";
                CConection.type = 2;
            }
            if (picker3.SelectedIndex == 2)
            {
                a3 = "23";
                b3 = "3";
                CConection.type = 3;
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            img.IsVisible = true;
            reg.IsVisible = true;
            c.Text = a1 + a2 + a3;
            img.BarcodeValue = c.Text + "1";
            CConection.sk = Int32.Parse(img.BarcodeValue);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            img.IsVisible = false;
            reg.IsVisible = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                CConection objConn = new CConection();

                objConn.MessGive();
                i += 1;
            }
            catch 
            {
                DisplayAlert("", "Не получилос", "ок");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TMP());
        }
    }
}