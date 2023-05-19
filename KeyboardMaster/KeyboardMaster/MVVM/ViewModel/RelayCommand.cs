﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeyboardMaster.MVVM.ViewModel
{
    class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly Action<object>? _execute;
        private readonly Func<object, bool>? _canExecute;

        public RelayCommand(Action<object>? execute, Func<object, bool>? canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute ?? throw new ArgumentNullException(nameof(execute));
        }

        public bool CanExecute(object? parameter) => _canExecute == null || _canExecute(parameter);

        public void Execute(object? parameter) => _execute(parameter);
    }
}
