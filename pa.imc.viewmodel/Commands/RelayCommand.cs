using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pa.imc.viewmodel.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

#pragma warning disable CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        public RelayCommand(Action<object> execute, Func<object, bool>? canExecute = null)
#pragma warning restore CS8618 // Ein Non-Nullable-Feld muss beim Beenden des Konstruktors einen Wert ungleich NULL enthalten. Erwägen Sie die Deklaration als Nullable.
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
#pragma warning disable CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
            CommandManager.RequerySuggested += OnRequerySuggested;
#pragma warning restore CS8622 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem Zieldelegaten.
        }

        private void OnRequerySuggested(object sender, EventArgs e)
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

#pragma warning disable CS8612 // Die NULL-Zulässigkeit von Verweistypen im Typ entspricht nicht dem implizit implementierten Member.
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS8612 // Die NULL-Zulässigkeit von Verweistypen im Typ entspricht nicht dem implizit implementierten Member.

#pragma warning disable CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.
        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;
#pragma warning restore CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.

#pragma warning disable CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.
        public void Execute(object parameter) => _execute(parameter);
#pragma warning restore CS8767 // Die NULL-Zulässigkeit von Verweistypen im Typ des Parameters entspricht (möglicherweise aufgrund von Attributen für die NULL-Zulässigkeit) nicht dem implizit implementierten Member.
    }
}
