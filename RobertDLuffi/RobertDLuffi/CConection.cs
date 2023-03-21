using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using Xamarin.Forms;
using ZXing;
using RobertDLuffi.Views;
using RobertDLuffi.ForDemostration;

namespace RobertDLuffi
{
   
     class CConection
    {
        
             
        NpgsqlConnection conn = new NpgsqlConnection();
        static String Server = "192.168.137.1 "; // сюда IPv4
        static String BD = "Pechkin"; // Сюда имя бд очевидно
        static String user = "postgres";
        static String password = "root"; // Пароль второй который от баз
        static String port = "5432";


        public static String massage = "";
        public static String us_login = "";// Логин пользователя
        public static String us_pas = "";// Пароль пользователя
        public static String newLog = "";// Новый Логин пользователя
        public static String newPas = "";// Новый Пароль пользователя
        public static String us_name = "";//Имя пользователя

        //------------ДААННЫЕ ДЛЯ ЗАНЕСЕНИЯ В ТАБЛИЦУ С ОТПРАВЛЕНИЯМИ------------------------

        public static String id ;// id
        public static String date ;// дата
        public static String time ;// время
        public static Int32 sk;// штрихкод
        public static Int32 p1;// место откуда
        public static Int32 p2;// место куда
        public static Int32 type;//тип

        //---------------------------------------------------------


        public static string[] phones = new string[] { };// Лист для вывода типов сообщений
        List<string> list = new List<string>();
        

        String cadenaConection = "server=" + Server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";"+"database="+BD+";";


        // Подключение к базе данных

        public  NpgsqlConnection estableConection()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                massage = "Подключение успешно";
               
            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }
            
            return conn;
        }

        // Вывод резульатов стобца name таблицы test

        public NpgsqlConnection ShowTypesMassage()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT \"name\" FROM \"test\"", conn);
                NpgsqlDataReader reader = npgc.ExecuteReader();
               
                while (reader.Read())
                {
                   
                    list.Add(reader.GetString(0));
                    phones = list.ToArray();
                }

                reader.Close();
                
            }
            catch (NpgsqlException e)
            {

                list.Add (e.ToString());
                phones = list.ToArray();
                
            }
            return conn;
        }

        // Проверка соответсвия логина 
        public NpgsqlConnection LoginFind()
        {
            try
            {

                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT \"login\" FROM \"users\" WHERE \"login\"= '"+MainP.lll+"'", conn);
                
               NpgsqlDataReader reader = npgc.ExecuteReader();

                while (reader.Read())
                {

                   us_login = reader.GetString(0);

                }

               reader.Close();

            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }

            return conn;
        }

        // Проверка соответсвия Пароля 
        public NpgsqlConnection PasswordFind()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT \"password\" FROM \"users\" WHERE \"login\" = '"+us_login+"'", conn);
                NpgsqlDataReader reader = npgc.ExecuteReader();
                

                while (reader.Read())
                {
                    
                    us_pas = reader.GetString(0);

                }

                reader.Close();
               

            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }

            return conn;
        }


        // Проверка соответсвия Пароля 
        public NpgsqlConnection NameFind()
        {
            try
            {
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT \"fio\" FROM \"workers\" WHERE \"login\" = '" + us_login + "'", conn);
                NpgsqlDataReader reader = npgc.ExecuteReader();
                while (reader.Read())
                {
                    us_name = reader.GetString(0);
                    
                }

                reader.Close();
                

            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }

            return conn;
        }


        // Регестрация Логина
        public NpgsqlConnection Create_login()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("INSERT INTO \"users\" VALUES (@log, @pas);", conn);
                npgc.Parameters.AddWithValue("@log", newLog);
                npgc.Parameters.AddWithValue("@pas", newPas);
                npgc.ExecuteNonQuery();
                massage = "Успешно";
            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }

            return conn;
        }



        // Внесение в таблицу messages
        public NpgsqlConnection MessGive()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("INSERT INTO \"messages\" VALUES (@id, @type, @bc, @p1, @p2);", conn);
                npgc.Parameters.AddWithValue("@id", SMP.i);
                npgc.Parameters.AddWithValue("@type", type);
                npgc.Parameters.AddWithValue("@bc", sk);
                npgc.Parameters.AddWithValue("@p1", p1);
                npgc.Parameters.AddWithValue("@p2",p2);
                npgc.ExecuteNonQuery();
                massage = "Успешно";
                
            }

            catch (NpgsqlException e)
            {
                massage = "не получилось" + e.ToString();
            }

            return conn;
        }




        // Вывод резульатов стобца name таблицы test

        public NpgsqlConnection ShowMessage()
        {
            try
            {
                conn.ConnectionString = cadenaConection;
                conn.Open();
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT  mes_type.\"type\" as \"type\" FROM messages INNER JOIN mes_type ON (messages.\"type\"= mes_type.\"id\") WHERE messages.\"id\"= @id", conn);
                npgc.Parameters.AddWithValue("@id", TMP.i);
                NpgsqlDataReader reader = npgc.ExecuteReader();

                while (reader.Read())
                {

                    TMP.ids +="Тип посылки: " + reader.GetString(0);  
                }

                reader.Close();

                

            }
            catch (NpgsqlException e)
            {
                TMP.ids = "Отпарвление не найдено";
               
            }
            return conn;
            
        }



        public NpgsqlConnection ShowMessage2()
        {
            try
            {
                
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT  chek_place.\"title\" as \"title\" FROM messages INNER JOIN chek_place ON (messages.\"place_1\"= chek_place.\"code\")WHERE messages.\"id\"=@id", conn);
                npgc.Parameters.AddWithValue("@id", TMP.i);
                NpgsqlDataReader reader = npgc.ExecuteReader();

                while (reader.Read())
                {

                    TMP.ids += "\nКуда: " +  reader.GetString(0);
                }

                reader.Close();


            }
            catch (NpgsqlException e)
            {


            }
            return conn;
        }


        public NpgsqlConnection ShowMessage3()
        {
            try
            {
                
                NpgsqlCommand npgc = new NpgsqlCommand("SELECT  chek_place.\"title\" as \"title\" FROM messages INNER JOIN chek_place ON (messages.\"place_2\"= chek_place.\"code\")WHERE messages.\"id\"=@id", conn);
                npgc.Parameters.AddWithValue("@id", TMP.i);
                NpgsqlDataReader reader = npgc.ExecuteReader();

                while (reader.Read())
                {

                    TMP.ids += "\nОткуда: "+ reader.GetString(0);
                }

                reader.Close();


            }
            catch (NpgsqlException e)
            {


            }
            return conn;
        }



        // Запись в таблицу отправления
        //public NpgsqlConnection SendMess()
        //{
        //    try
        //    {
        //        conn.ConnectionString = cadenaConection;
        //        conn.Open();
        //        id = Page5.id;
        //        date = Page5.date;
        //        time = Page5.time;
        //        sk = Page5.sk;
        //        p1  = Page5.p1;
        //        p2 = Page5.p2;

        //        NpgsqlCommand npgc = new NpgsqlCommand("INSERT INTO sending_mess VALUES (@id, @date, @time, @sk, @p1, @p2)", conn);

        //        npgc.Parameters.AddWithValue("@id", id);
        //        npgc.Parameters.AddWithValue("@date", date);
        //        npgc.Parameters.AddWithValue("@time", time);
        //        npgc.Parameters.AddWithValue("@sk", sk);
        //        npgc.Parameters.AddWithValue("@p1", p1);
        //        npgc.Parameters.AddWithValue("@p2", p2);
        //        npgc.ExecuteNonQuery();

        //        massage = "Успешно";
        //    }

        //    catch (NpgsqlException e)
        //    {
        //        massage = "не получилось" + e.ToString();
        //    }

        //    return conn;
        //}
    }
}
