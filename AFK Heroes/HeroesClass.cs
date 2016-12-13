using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AFK_Heroes
{
    public class HeroesClass
    {
        private int dps = 1;
        private string name = "Default";
        private int level = 1;

        public string GetName()
        {
            return name;
        }

        public void SetName(string nameSet)
        {
            name = nameSet;
        }

        public int GetDPS()
        {
            return dps;
        }

        public void AddDPS(int dpsAdd)
        {
            dps = dps + dpsAdd;
        }

        public void UpdateDPS()
        {
            if (dps < 5)
            {
                dps = dps + 1;
            }
            else if (dps > 4)
            {
                int toAdd = dps + (dps / 4);
                dps = dps + toAdd;
            }
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int levelSet)
        {
            level = level + levelSet;
        }
    }
}

