using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    class CEnemyTemplateList
    {
        List<CEnemyTemplate> enemies;
        public CEnemyTemplateList()
        {
            enemies = new List<CEnemyTemplate>();
        }
        public void addEnemy(string name, string iconName, int baseLife, double lifeModifier, int baseGold, double goldModifier, double spawnChance)
        {
            enemies.Add(new CEnemyTemplate(name, iconName, baseLife, lifeModifier, baseGold, goldModifier, spawnChance));
        }
        public CEnemyTemplate getEnemyByName(string name)
        {
            foreach(CEnemyTemplate enemy in enemies)
            {
                if (enemy.Name() == name)
                {
                    return enemy;
                }
            }
            return null;
        }
        public CEnemyTemplate getEnemyByInndex(int id)
        {
            if (id >=0 && id < enemies.Count)
            {
                return enemies[id];
            }
            return null;
        }

    }
}
