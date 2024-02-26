using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Предоставляет команды для работы с MainVM.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Метод, который необходимо выполнить.
        /// </summary>
        private Action<object?> execute;

        /// <summary>
        /// Условие, определяющая можно ли выполнить метод.
        /// </summary>
        private Func<object?, bool>? canExecute;

        /// <summary>
        /// <inheritdoc/>.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Выполняемый метод.</param>
        /// <param name="canExecute">Условие, определяющая можно ли выполнить метод.</param>
        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// <inheritdoc/>.
        /// </summary>
        /// <param name="parameter"><inheritdoc/>.</param>
        /// <returns><inheritdoc/>.</returns>
        public bool CanExecute(object? parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        /// <summary>
        /// <inheritdoc/>.
        /// </summary>
        /// <param name="parameter"><inheritdoc/>.</param>
        public void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
