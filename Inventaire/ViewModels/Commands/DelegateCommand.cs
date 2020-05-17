using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace BillingManagement.UI.ViewModels.Commands
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;
        private Action<object, RoutedEventArgs> exit_Click;

        public DelegateCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(object exit_Click)
        {
        }

        public DelegateCommand(Action<object, RoutedEventArgs> exit_Click)
        {
            this.exit_Click = exit_Click;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;

            return _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
