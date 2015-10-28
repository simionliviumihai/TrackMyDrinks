using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TrackMyDrinks.Utils
{
    delegate void CommandDelegate(object param);

    class DelegateCommand : ICommand
    {
        private CommandDelegate command;

        public DelegateCommand(CommandDelegate command)
        {
            this.command = command;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            command(parameter);
        }
    }
}
