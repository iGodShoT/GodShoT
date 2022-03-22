using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class AuthorizationViewModel : INotifyPropertyChanged, ILoaded
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _login;
        private string _password;
        private DelegateCommand _authorization;
        private List<User> _users;
        public void Loaded()
        {
            string directory = Directory.GetCurrentDirectory();
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (StreamReader sr = new StreamReader(File.Open(directory + "/users.txt", FileMode.OpenOrCreate)))
                Users = (List<User>)serializer.Deserialize(sr);
        }
        public Action Close { get; set; }
        public DelegateCommand Authorization
        {
            get
            {
                return _authorization ?? (_authorization = new DelegateCommand(obj =>
                {
                    Password = ((PasswordBox)obj).Password;
                    foreach (User user in Users)
                    {
                        if (user.Login == Login && user.Password == Password)
                        {
                            switch (user.Role)
                            {
                                case User.ERole.Admin:
                                    AdminView adminView = new AdminView();
                                    adminView.Show();
                                    Close?.Invoke();
                                    break;
                                case User.ERole.HR:
                                    HRView hrView = new HRView();
                                    hrView.Show();
                                    Close?.Invoke();
                                    break;
                                case User.ERole.Storekeeper:
                                    StorekeeperView storekeeperView = new StorekeeperView();
                                    storekeeperView.Show();
                                    Close?.Invoke();
                                    break;
                                case User.ERole.Cashier:
                                    CashierView cashierView = new CashierView();
                                    cashierView.Show();
                                    Close?.Invoke();
                                    break;
                                case User.ERole.Client:
                                    ClientView clientView = new ClientView();
                                    clientView.Show();
                                    Close?.Invoke();
                                    break;
                            }
                        }
                    }
                }));
            }
        }
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
        public List<User> Users
        {
            get => _users;
            set { _users = value; NotifyPropertyChanged(); }
        }
        private async void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
