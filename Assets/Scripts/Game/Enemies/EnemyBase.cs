using UnityEngine;
using Buginator.Settings;

namespace Buginator.Game
{
    public class EnemyBase : MonoBehaviour
    {
        //public float Speed;
        //public int Health;
        //public int Damage;
        //public float AttackSpeed;
        [SerializeField]
        private EnemySettingsSO _settings;

        public void Init(Vector3 position, Transform parent, Transform target)
        {
            transform.SetParent(parent);
            transform.position = position;
            transform.LookAt(target);
        }
    }
}