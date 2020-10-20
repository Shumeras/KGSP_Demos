using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPFDemo.Commands
{
    public class RelayCommand : ICommand
    {
        #region Private members
        
        private bool isExecutable;
        private Action<object> action;

        #endregion

        public bool IsExecutable
        {
            get => isExecutable;
            set
            {
                if (isExecutable == value) return;

                isExecutable = value;
                CanExecuteChanged(this, null);
            }
        }

        public RelayCommand(Action<object> action, bool isExecutable = true)
        {
            this.action = action;
            this.isExecutable = isExecutable;
        }

        #region ICommand 
        public event EventHandler CanExecuteChanged = (o, args) => {};

        public bool CanExecute(object parameter)
        {
            return IsExecutable;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }

        #endregion
    }
}
