using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tools
{
    public class ActionCommand : ICommand
    {
        #region members private
        private Action<object> _execute;

        private Predicate<object> _canExecute;

        #endregion

        #region constructor
        public ActionCommand(Action<object> execute) : this(execute, DefaultCanExecute)
        {

        }

        public ActionCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute != null)
                this._execute = execute;

            if (canExecute != null)
                this._canExecute = canExecute;
           
        }
        #endregion
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return (this._canExecute != null && this._canExecute(parameter));
        }

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        private static bool DefaultCanExecute(object _parameter)
        {
            return true;
        }

    }
}
