using System;
using UnityEngine;

namespace Buginator.Game
{
    [Serializable]
    public class EnemyPrefab
    {
        public GameData.GameData.EnemyType Type;
        public GameObject Prefab;
    }
}