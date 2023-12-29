
using EvernoteClone.Models;
using EvernoteClone.ViewModels.Commands;

namespace EvernoteClone.ViewModels
{
    public class LoginVM
    {
		private User user;

		public User User
		{
			get { return user; }
			set { user = value; }
		}

        public RegisterCommands RegisterCommands { get; set; }

        public LoginCommand LoginCommand { get; set; }

        public LoginVM()
		{
			RegisterCommands = new RegisterCommands(this);
			LoginCommand = new LoginCommand(this);
		}

    }
}
