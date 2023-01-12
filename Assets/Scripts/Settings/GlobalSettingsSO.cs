using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Buginator.Settings
{
    [CreateAssetMenu(fileName = "Settings", menuName = "GameSettings/GlobalSettings")]
    public class GlobalSettingsSO : ScriptableObject
    {
        [Header("Levels")]
        [SerializeField]
        private List<LevelSettingsSO> _levels;
        [Header("Player")]
        [SerializeField]
        private PlayerSettings _player;
        [Header("Enemies")]
        [SerializeField]
        private List<EnemySettingsSO> _enemies;

        internal LevelSettingsSO GetLevel(int number)
        {
            return _levels.Find(l => l.Number == number);
        }
    }
}
