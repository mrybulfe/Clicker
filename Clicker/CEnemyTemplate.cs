using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Clicker
{
    class CEnemyTemplate
    {
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
            this.name = name;
            this.iconName = iconName;
            this.baseLife = baseLife;
            this.lifeModifier = lifeModifier;
            this.baseGold = baseGold;
            this.goldModifier = goldModifier;
            this.spawnChance = spawnChance;
        }

        public string Name()
        {
            return name;
        }
        public string IconName()
        {
            return iconName;
        }
        public int BaseLife()
        {
            return baseLife;
        }
        public double LifeModifier()
        {
            return lifeModifier;
        }
        public int BaseGold()
        {
            return baseGold;
        }

        public double GoldModifier()
        {
            return goldModifier;
        }
        public double SpawnChance()
        {
            return spawnChance;
        }
    }
}
