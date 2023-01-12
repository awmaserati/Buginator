using System;

namespace Buginator.Settings
{
    [Serializable]
    public class LevelEnemySettings
    {
        public GameData.GameData.EnemyType EnemyType;
        public int Count;
    }
}