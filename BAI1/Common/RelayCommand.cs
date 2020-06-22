using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BAI1.Common
{
    public class RelayCommand : ICommand
    {
        // Token: 0x0600008F RID: 143 RVA: 0x0000409A File Offset: 0x0000229A
        public RelayCommand(Action<object> execute) : this(execute, null)
        {
        }

        // Token: 0x06000090 RID: 144 RVA: 0x000040A6 File Offset: 0x000022A6
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        // Token: 0x06000091 RID: 145 RVA: 0x000040C0 File Offset: 0x000022C0
        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this._canExecute(parameter);
        }

        // Token: 0x06000092 RID: 146 RVA: 0x000040E9 File Offset: 0x000022E9
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        // Token: 0x14000001 RID: 1
        // (add) Token: 0x06000093 RID: 147 RVA: 0x000040F9 File Offset: 0x000022F9
        // (remove) Token: 0x06000094 RID: 148 RVA: 0x00004103 File Offset: 0x00002303
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

        // Token: 0x04000053 RID: 83
        private Action<object> _execute;

        // Token: 0x04000054 RID: 84
        private Predicate<object> _canExecute;
    }
}
