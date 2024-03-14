﻿using Newtonsoft.Json;
using System;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Сервисный класс для сохранения и загрузки контактов.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Относительный путь к папке, где должен лежать файл json.
        /// </summary>
        private static readonly string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts";

        /// <summary>
        /// Относительный путь к файлу json.
        /// </summary>
        private static readonly string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts\\contacts.json";

        /// <summary>
        /// Сохраняет контакт в json.
        /// </summary>
        /// <param name="contact">Сохраняемый контакт.</param>
        public static void SaveContact(Contact? contact)
        {
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            File.WriteAllText(_jsonPath, string.Empty);
            File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(contact));
        }

        /// <summary>
        /// Загружает контакт из json.
        /// </summary>
        /// <returns>Возвращает загруженный контакт.</returns>
        public static Contact? LoadContact()
        {
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
            JsonTextReader reader = new(new StreamReader(_jsonPath))
            {
                SupportMultipleContent = true
            };
            JsonSerializer serializer = new();
            Contact? tempContact = serializer.Deserialize<Contact>(reader);
            return tempContact;
        }
    }
}
