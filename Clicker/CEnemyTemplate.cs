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

        string name;
        string iconName;
        int baseLife;
        double lifeModifier;
        int baseGold;
        double goldModifier;
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

        [JsonInclude]
        public string Name { get; set; }
        [JsonInclude]
        public string IconName { get; set; }
        [JsonInclude]
        public int BaseLife { get; set; }
        [JsonInclude]
        public double LifeModifier { get; set; }
        [JsonInclude]
        public int BaseGold { get; set; }
        [JsonInclude]

        public double GoldModifier { get; set; }
        [JsonInclude]
        public double SpawnChance{ get; set; }
    }
}
