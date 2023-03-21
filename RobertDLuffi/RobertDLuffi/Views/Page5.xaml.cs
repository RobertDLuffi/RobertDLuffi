using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.Xaml;

namespace RobertDLuffi.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
        public static int id ;
        public static string date;
        public static string time;
        public static string sk;
        public static string p1;
        public static string p2;
        public Page5 ()
		{
			InitializeComponent ();
           
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            CConection objConn = new CConection();
            id = 1;
            date = s_date.Text;
            time = s_time.Text;
            p1 = s_p1.Text;
            p2 = s_p2.Text;
            sk = scan.Text;
            //objConn.SendMess();
            //lbl.Text = CConection.massage;
        }

        private  async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TablePageSend());
        }
    }
}