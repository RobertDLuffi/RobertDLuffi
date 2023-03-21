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
	public partial class RegP : ContentPage
	{
		public RegP ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (newlog.Text.Equals("")||newPas.Text.Equals(""))
            {
                await DisplayAlert("Предупреждение", "Логин и пароль не могут быть пустыми", "ок");
            }
            else
            {
                CConection.newLog = newlog.Text;
                CConection.newPas = newPas.Text;
                CConection objConn = new CConection();
                objConn.Create_login();
                await DisplayAlert("", "Аккаунт зарегестрирован", "ок");
                await Navigation.PopAsync();
                
            }
        }
    }
}