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

namespace RobertDLuffi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public string a1;
        public string a2;
        public string a3;
        public string a4;

        public Page4()
        {
            InitializeComponent();
            
        }

        private void picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (picker2.SelectedIndex == 0)
            {
                a2 = "01";
                
            }
            if (picker2.SelectedIndex == 1)
            {
               a2 = "02";
            }
            if (picker2.SelectedIndex == 2)
            {
               a2 = "03";
            }
            if (picker2.SelectedIndex == 3)
            {
                a2 = "04";
            }
        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (picker1.SelectedIndex == 0)
            {
                a1 = "12";
            }
            if (picker1.SelectedIndex == 1)
            {
                a1 = "13";
            }
            if (picker1.SelectedIndex == 2)
            {
                a1 = "14";
            }
            if (picker1.SelectedIndex == 3)
            {
                a1 = "15";
            }
        }

        private void picker3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (picker3.SelectedIndex == 0)
            {
                a3 = "22";


            }
            if (picker3.SelectedIndex == 1)
            {
                a3 = "21";
            }
            if (picker3.SelectedIndex == 2)
            {
               a3 = "23";
            }
            if (picker3.SelectedIndex == 3)
            {
               a3 = "24";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            img.IsVisible= true;
            c.Text = a1 + a2 + a3;
            img.BarcodeValue = c.Text + "1";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            img.IsVisible = false;
        }
    }
}