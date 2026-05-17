using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;


namespace OOP_CarParts_Kolkov.Models
{
    /// <summary>
    /// Клас для забезпечення збереження та завантаження 
    /// бази данних каталогу у форматі JSON.
    /// </summary>


    internal class JsonService
    {
        private readonly string _filePath;
        private readonly JsonSerializerOptions _options;

        public JsonService(string filePath)
        {
            _filePath = filePath;

            _options = new JsonSerializerOptions
            { WriteIndented = true, PropertyNameCaseInsensitive = true };
        }

        /// <summary>
        /// Метод для збереження динних каталогу в базу данних JSON
        /// </summary>
        /// <param name="parts"></param>
        /// <exception cref="Exception"></exception>
         
        public void Save(List<Part> parts)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(parts, _options);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка збереження данних: " + ex.Message);
            }
        }

        /// <summary>
        /// Завантажує базу данних запчастин із файлу
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Part> Load()
        {
            try
            {
                if(!File.Exists(_filePath))
                    return new List<Part>();
                string jsonString = File.ReadAllText(_filePath);
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    return new List<Part>();
                }
                return JsonSerializer.Deserialize<List<Part>>(jsonString, _options) ?? new List<Part>();
            }
            catch (Exception ex) 
            {
                throw new Exception("Помилка при завантаженні даних: " + ex.Message);
            }
        }
    }
}
