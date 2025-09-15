using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clicker
{
    public class CEnemyTemplate : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [JsonInclude]
        string name;
        [JsonInclude]
        string iconName;
        [JsonInclude]
        int baseLife;
        [JsonInclude]
        double lifeModifier;
        [JsonInclude]
        int baseGold;
        [JsonInclude]
        double goldModifier;
        [JsonInclude]
        double spawnChance;

        public CEnemyTemplate(string name, string iconName, int baseLife, double lifeModifier, int baseGold, double goldModifier, double spawnChance)
        {
            Name = name;
            IconName = iconName;
            BaseLife = baseLife;
            LifeModifier = lifeModifier;
            BaseGold = baseGold;
            GoldModifier = goldModifier;
            SpawnChance = spawnChance;
        }

        public string Name { get; set; }
        
        public string IconName { get; set; }
        public int BaseLife { get; set; }
        public double LifeModifier { get; set; }
        public int BaseGold { get; set; }

        public double GoldModifier { get; set; }
        public double SpawnChance{ get; set; }
    }
}
