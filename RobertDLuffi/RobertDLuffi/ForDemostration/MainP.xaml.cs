using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Npgsql;
using System.Data;

namespace RobertDLuffi.ForDemostration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainP : ContentPage
	{
        public static string lll = "";
        public MainP ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegP());
        }

        private void Bb_Clicked(object sender, EventArgs e)
        {
            lll = LG.Text;
            CConection objConn = new CConection();
            objConn.LoginFind();
            DisplayAlert("gg","lll = "+lll+" us_login = " +CConection.us_login, "jr");
            
            if (LG.Text == CConection.us_login)

                {
                    DisplayAlert("", "Верный", "ок");
                    pls.IsVisible = true;
                    ps.IsVisible = true;
                    Bb.IsVisible = false;
                    bb2.IsVisible = true;

                }
            else
            {
                DisplayAlert("ОШИБКА", "Неверный логин", "Ладушки");
            }




            //objConn.estableConection();
            //label.Text += CConection.massage;
        }

        private async void bb2_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                CConection objConn = new CConection();
                objConn.PasswordFind();
                objConn.NameFind();
                if (ps.Text == CConection.us_pas)
                {
                   await DisplayAlert("", "Верный", "ок");
                   await Navigation.PushAsync(new AutoP(CConection.us_name,CConection.us_login));
                }
                
            }
            catch 
            {
                await DisplayAlert("Ошибка", "Неверно введен пароль", "ок");
            }
        }
    }
}