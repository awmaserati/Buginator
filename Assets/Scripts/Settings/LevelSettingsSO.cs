using System.Collections.Generic;
using UnityEngine;

namespace Buginator.Settings
{
    [CreateAssetMenu(fileName = "LevelSettings", menuName = "GameSettings/Level")]
    public class LevelSettingsSO : ScriptableObject
    {
        [SerializeField]
        internal int Number;
        [SerializeField]
        internal List<LevelEnemySettings> Enemies;
        [SerializeField]
        internal float SpawnDelay;
    }
}