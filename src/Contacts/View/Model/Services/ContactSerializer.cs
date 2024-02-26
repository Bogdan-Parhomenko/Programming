using Newtonsoft.Json;
using System;
using System.IO;

namespace View.Model.Services
{
    static class ContactSerializer
    {
        /// <summary>
        /// Относительный путь к папке, где должен лежать файл json.
        /// </summary>
        private static string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts";

        /// <summary>
        /// Относительный путь к файлу json.
        /// </summary>
        private static string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Contacts\\contacts.json";

        public static void SaveContact(Contact contact)
        {
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            File.WriteAllText(_jsonPath, string.Empty);
            File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(contact));
        }

        public static Contact LoadContact()
        {
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
            JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath));
            reader.SupportMultipleContent = true;
            JsonSerializer serializer = new JsonSerializer();
            Contact tempContact = serializer.Deserialize<Contact>(reader);
            reader.Close();
            return tempContact;
        }
    }
}
