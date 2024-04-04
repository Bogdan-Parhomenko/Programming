using System.Collections;
using System.ComponentModel;

namespace Model.Services
{
    /// <summary>
    /// Сервисный класс, предоставляющий возможность выводить ошибки.
    /// </summary>
    public class ErrorsValidator : INotifyDataErrorInfo
    {
        /// <summary>
        /// Хранит пары значений: Название свойства и Список его ошибок.
        /// </summary>
        private readonly Dictionary<string, List<string>> _propertyErrors = new();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool HasErrors => _propertyErrors.Any();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="propertyName"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        /// <summary>
        /// Добавляет ошибку по ключу и обновляет интерфейс.
        /// </summary>
        /// <param name="propertyName">Имя свойства, по какому ключу добавляется ошибка.</param>
        /// <param name="errorMessage">Текст ошибки.</param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        /// <summary>
        /// Удаляет все ошибки по ключу и обновляет интерфейс.
        /// </summary>
        /// <param name="propertyName">Имя свойства, по какому ключу удаляются ошибки.</param>
        public void CleanErrors(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// Оповещает систему об изменении словаря ошибок по ключу.
        /// </summary>
        /// <param name="propertyName">Имя свойства, по какому ключу происходит оповещение системы.</param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
