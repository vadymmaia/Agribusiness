using Agribusiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AgroBusinessApp
{
    public class AgroDataManager
    {
        private readonly string _filePath = "agro_db.json";

        public List<AgroProduct> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<AgroProduct>();

            try
            {
                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<AgroProduct>>(json) ?? new List<AgroProduct>();
            }
            catch
            {
                return new List<AgroProduct>();
            }
        }

        public void SaveData(List<AgroProduct> products)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(products, options);
            File.WriteAllText(_filePath, json);
        }

        public void CreateBackup()
        {
            if (File.Exists(_filePath))
            {
                string backupPath = $"backup_agro_{DateTime.Now:yyyyMMdd_HHmmss}.json";
                File.Copy(_filePath, backupPath, overwrite: true);
            }
        }
    }
}