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

        public CEnemyTemplate getEnemyByName(string name)
        {
            foreach (CEnemyTemplate enemy in enemies)

            {
                if (enemy.Name == name)
                {
                    return enemy;
                }
            }
            return null;
        }
        public CEnemyTemplate getEnemyByIndex(int id)
        {
            if (id >= 0 && id <= enemies.Count)
            {
                return enemies[id];
            }
            return null;
        }
        public void deleteEnemyByName(string name)
        {
            foreach (CEnemyTemplate enemy in enemies)
            {
                if (enemy.Name == name)
                {
                    enemies.Remove(enemy);
                }
            }
        }

        public void deletetEnemyByIndex(int id)
        {
            if (id >= 0 && id <= enemies.Count)
            {
                enemies.RemoveAt(id);
            }
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
            List<CEnemyTemplate> enemies = new List<CEnemyTemplate>();
            JsonDocument doc = JsonDocument.Parse(path);
            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                string name = element.GetProperty("age").GetString();
                string iconName = element.GetProperty("iconName").GetString();
                int baseLife = element.GetProperty("baseLife").GetInt32();
                double lifeModifier = element.GetProperty("lifeModifier").GetDouble();
                int baseGold = element.GetProperty("baseGold").GetInt32();
                double goldModifier = element.GetProperty("goldModifier").GetDouble();
                double spawnChance = element.GetProperty("spawnChance").GetDouble();
                CEnemyTemplate enemy = new CEnemyTemplate(name, iconName, baseLife, lifeModifier, baseGold, goldModifier, spawnChance);
                enemies.Add(enemy);
            }

        }
    }
}
