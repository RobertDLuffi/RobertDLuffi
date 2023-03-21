using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Npgsql;
using System.Data;

namespace RobertDLuffi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSQLcon : ContentPage
    {
        public static string lll;
        public PageSQLcon()
        {
            InitializeComponent();
             
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //string connString = " Host=172.20.10.2 ; Username=postgres ; Password=gfhjkmdfcz ; Database=MRMailBD ";
            //using (var connection = new NpgsqlConnection(connString))
            //{
            //connection.Open();
            //using (var command = connection.CreateCommand())
            //{
            //command.CommandText = "SELECT 'Name' FROM public.\"Robert\"";
            //using (var reader = command.ExecuteReader())
            // {
            //while (reader.Read())
            //{
            //var id = (long)reader["Name"];

            //label.Text = "e";
            //NpgsqlConnection nc = new NpgsqlConnection(connString);
            //try
            //{
            //    //Открываем соединение.
            //    nc.Open();
            //}
            //catch (Exception ex)
            //{
            //    //Код обработки ошибок
            //}
            //NpgsqlCommand npgc = new NpgsqlCommand("SELECT * FROM public.\"Packages\"", nc);
            //int rows_changed = npgc.ExecuteNonQuery();//Если запрос не возвращает таблицу
            //NpgsqlDataReader ndr = npgc.ExecuteReader();//Если запрос возвращает таблицу

            //NpgsqlDataReader reader = npgc.ExecuteReader();
            //if (reader.HasRows)//Если пришли результаты
            //{
            //    label.Text = "GODKSGSPGSG";
            //}
            CConection objConn = new CConection();
            objConn.ShowTypesMassage();
           
            phonesList.ItemsSource = CConection.phones;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CConection objConn = new CConection();
            objConn.estableConection();
            label.Text += CConection.massage;
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            lll = LG.Text;
            CConection objConn = new CConection();
            objConn.LoginFind();
            if (LG.Text == CConection.us_login) 

            {
                DisplayAlert("", "Верный", "ок");
                
            }
            else
            {
                DisplayAlert("ОШИБКА", "Неверный логин или пароль", "Ладушки");
            }
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            CConection objConn = new CConection();
            objConn.PasswordFind();
            if (PS.Text == CConection.us_pas)

            {
                DisplayAlert("Умница", "ТЫ НЕВЕРОЯТЕН", "Ладушки");

            }
            else
            {
                DisplayAlert("ОШИБКА", "Неверный логин или пароль", "Ладушки");
            }
        }
        //Регистрация нового пользователя
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            CConection objConn = new CConection();
            objConn.Create_login();
            rLG.Text = CConection.massage;
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
    }
 }

            