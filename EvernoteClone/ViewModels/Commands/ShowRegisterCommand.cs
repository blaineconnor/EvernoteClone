﻿using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModels.Commands
{
    public class ShowRegisterCommand : ICommand
    {
        public LoginVM ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public ShowRegisterCommand(LoginVM vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.SwitchViews();
        }
    }
}
