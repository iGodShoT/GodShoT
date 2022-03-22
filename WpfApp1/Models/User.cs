using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _surname;
        private string _name;
        private string _middlename;
        private int _age;
        private string _email;
        private EEducation _education;
        private ERole _role;
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set { _login = value; NotifyPropertyChanged(); }
        }
        public string Password
        {
            get => _password;
            set { _password = value; NotifyPropertyChanged(); }
        }
        public string Surname
        {
            get => _surname;
            set { _surname = value; NotifyPropertyChanged(); }
        }
        public string Name
        {
            get => _name;
            set { _name = value; NotifyPropertyChanged(); }
        }
        public string Middlename
        {
            get => _middlename;
            set { _middlename = value; NotifyPropertyChanged(); }
        }
        public string Email
        {
            get => _email;
            set { _email = value; NotifyPropertyChanged(); }
        }
        public int Age
        {
            get => _age;
            set { _age = value; NotifyPropertyChanged(); }
        }
        public EEducation Education
        {
            get => _education;
            set { _education = value; NotifyPropertyChanged(); }
        }
        public ERole Role
        {
            get => _role;
            set { _role = value; NotifyPropertyChanged(); }
        }

        private async void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public enum EEducation { Associate, Bachelor, Master, Doctor}
        public enum ERole { Admin, HR, Storekeeper, Cashier, Client }
    }
}
