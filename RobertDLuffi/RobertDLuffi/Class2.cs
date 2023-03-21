using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static Xamarin.Essentials.Permissions;

namespace RobertDLuffi
{
    public class Class2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Class1 phone;

        public Class2()
        {
            phone = new Class1();
        }

        public string res_scan
        {
            get { return phone.res_scan; }
            set
            {
                if (phone.res_scan != value)
                {
                    phone.res_scan = value;
                    OnPropertyChanged("res_scan");
                }
            }
        }
       
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
