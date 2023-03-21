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
	public partial class TMP : ContentPage
	{
		public static string ids;
		public static int i;
		public TMP ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			try
			{
				ids = "";
				i = Int32.Parse(a.Text);
				a.Text = CConection.id;
				CConection objConn = new CConection();
				objConn.ShowMessage();
				objConn.ShowMessage2();
				objConn.ShowMessage3();
				lbls.Text = ids;
			}
			catch
			{
				
				DisplayAlert("ОШИБКА", "Поле ввода не может быть пустым", "ок");
			}
        }
    }
}