using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Buginator.Settings;

namespace Buginator.Game
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private List<SpawnPoint> _spawnPoints;
        [SerializeField]
        private List<EnemyPrefab> _enemyPrefabs;
        [SerializeField]
        private Transform _player;
        internal IEnumerator StartSpawn(LevelSettingsSO levelSettings)
        {
            var spawnedCount = 0;
            var typesCount = new Dictionary<GameData.GameData.EnemyType, int>();

            foreach(var enemySettings in levelSettings.Enemies)
            {
                spawnedCount += enemySettings.Count;
                typesCount.Add(enemySettings.EnemyType, enemySettings.Count);
            }

            do
            {
                yield return levelSettings.SpawnDelay;

                var type = 0;
                var enemyType = typesCount.ElementAt(type).Key;

                do
                {
                    type = Random.Range(0, typesCount.Count);
                    enemyType = typesCount.ElementAt(type).Key;
                } while (typesCount[enemyType] == 0);

                var prefab = _enemyPrefabs.Find(ep => ep.Type == enemyType);
                var spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

                var go = Instantiate(prefab.Prefab);
                var view = go.GetComponent<EnemyBase>();
                view.Init(spawnPoint.Position, transform, _player);

            } while (spawnedCount > 0);
        }
    }
}
