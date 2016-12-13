using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFK_Heroes
{
    class EnemyDict
    {
        Dictionary<int, string> Enemies = new Dictionary<int, string>();
        Dictionary<int, string> Bosses = new Dictionary<int, string>();

        public void Init()
        {
            Enemies.Add(1, "Jeff");
            Enemies.Add(2, "Phil");
            Enemies.Add(3, "Obama");
            Enemies.Add(4, "George");
            Enemies.Add(5, "Ralph");
            Enemies.Add(6, "Sarah");
            Enemies.Add(7, "Ryan");
            Enemies.Add(8, "Steve");
            Enemies.Add(9, "Ronald");
            Enemies.Add(10, "Susan");
            Enemies.Add(11, "Peter");
            Enemies.Add(12, "Kim");
            Enemies.Add(13, "Doug");
            Enemies.Add(14, "Peter");
            Enemies.Add(15, "Donald");
            Enemies.Add(16, "John");
            Enemies.Add(17, "Paul");
            Enemies.Add(18, "Martha");
            Enemies.Add(19, "Todd");
            Enemies.Add(20, "Jim");

            Bosses.Add(1, "Ben the homosexual");
            Bosses.Add(2, "Jake the gay");
            Bosses.Add(3, "Zarya the dike");
            Bosses.Add(4, "D'va the slutty whore bag");
            Bosses.Add(5, "Dr. Jakedoesnthavenstein");
            Bosses.Add(6, "Jamboni the great");
            Bosses.Add(7, "Lord Trump");
        }

        public string GetRandomEnemy(int num)
        {
            return Enemies[num];
        }

        public string GetRandomBoss(int num)
        {
            return Bosses[num];
        }

        public int GetEnemyCount()
        {
            return Enemies.Count;
        }

        public int GetBossCount()
        {
            return Bosses.Count();
        }
    }
}
