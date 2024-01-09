
using EvernoteClone.Models;
using EvernoteClone.ViewModels.Commands;
using System.ComponentModel;
using System.Windows;

namespace EvernoteClone.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
		private bool isShowRegister = false;

		private User user;

		public User User
		{
			get { return user; }
			set { user = value; }
		}

		private Visibility loginVis;
        private Visibility registerVis;


        public event PropertyChangedEventHandler PropertyChanged;

        public Visibility LoginVis
		{
			get { return loginVis; }
			set { 
				loginVis = value;
				OnPropertyChanged("LoginVis");
			}
		}
        public Visibility RegisterVis
        {
            get { return registerVis; }
            set
            {
                registerVis = value;
                OnPropertyChanged("RegisterVis");
            }
        }

        public RegisterCommands RegisterCommands { get; set; }

        public LoginCommand LoginCommand { get; set; }
        public ShowRegisterCommand ShowRegisterCommand { get; set; }

        public LoginVM()
		{
			LoginVis = Visibility.Visible;
			RegisterVis = Visibility.Collapsed;
			RegisterCommands = new RegisterCommands(this);
			LoginCommand = new LoginCommand(this);
			ShowRegisterCommand = new ShowRegisterCommand(this);
		}

		public void SwitchViews()
		{
			isShowRegister = !isShowRegister;
			if(isShowRegister)
			{
				RegisterVis = Visibility.Visible;
				LoginVis = Visibility.Collapsed;
			}
			else
			{
				RegisterVis = Visibility.Collapsed;
				LoginVis = Visibility.Visible;
			}
		}

		public void Login()
		{

		}
        public void Register()
        {

        }

        private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}
