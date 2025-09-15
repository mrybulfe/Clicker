using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;

namespace Clicker
{
    public class CEnemyTemplateList 
    {
        [JsonInclude]
        public ObservableCollection<CEnemyTemplate> enemies { get; set; }
        public CEnemyTemplateList()
        {
            enemies = new ObservableCollection<CEnemyTemplate>();
        }
        public void addEnemy(string name, string iconName, int baseLife, double lifeModifier, int baseGold, double goldModifier, double spawnChance)
        {
            enemies.Add(new CEnemyTemplate(name, iconName, baseLife, lifeModifier, baseGold, goldModifier, spawnChance));
        }

        
        //public List<string> getListOfEnemyNames()
        //{
        //    List<string> enemyNames = new List<string>();
        //    foreach (CEnemyTemplate enemy in enemies)
        //    {
        //        enemyNames.Add(enemy.Name());
        //    }
        //    return enemyNames;
        //}

        public void saveToJson (string path)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(enemies);
                File.WriteAllText(path, jsonString);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла");
            }
        }
        public void loadFromJson(string path)
        {
            string jsonFromFile = File.ReadAllText(path);
            enemies.Clear();
            JsonDocument doc = JsonDocument.Parse(jsonFromFile);
            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                string name = element.GetProperty("Name").GetString();                
                string iconName = element.GetProperty("IconName").GetString();
                int baseLife = element.GetProperty("BaseLife").GetInt32();
                double lifeModifier = element.GetProperty("LifeModifier").GetDouble();
                int baseGold = element.GetProperty("BaseGold").GetInt32();
                double goldModifier = element.GetProperty("GoldModifier").GetDouble();
                double spawnChance = element.GetProperty("SpawnChance").GetDouble();
                CEnemyTemplate enemy = new CEnemyTemplate(name, iconName, baseLife, lifeModifier, baseGold, goldModifier, spawnChance);
                enemies.Add(enemy);
            }

        }
        public string ShowSaveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = ".json";

            if (saveFileDialog.ShowDialog() == true)
            {
                return saveFileDialog.FileName;
            }
            return null;
        }

        public string ShowOpenDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.DefaultExt = ".json";

            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
