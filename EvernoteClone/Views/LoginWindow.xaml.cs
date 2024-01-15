using DevExpress.Xpf.Core;
using EvernoteClone.ViewModels;
using System;


namespace EvernoteClone.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : ThemedWindow
    {
        LoginVM vm;

        public LoginWindow()
        {
            InitializeComponent();

            vm = Resources["vm"] as LoginVM;
            vm.Authenticated += VM_Authenticated;
        }

        private void VM_Authenticated(object sender, EventArgs e)
        {
            Close();
        }
    }
}
