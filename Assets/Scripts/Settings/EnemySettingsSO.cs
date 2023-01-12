using System.Collections;
using UnityEngine;

namespace Buginator.Settings
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "GameSettings/Enemy")]
    public class EnemySettingsSO : ScriptableObject
    {
        public GameData.GameData.EnemyType Type;
        public float Speed;
        public int Health;
        public int Damage;
        public float AttackSpeed;
    }
}