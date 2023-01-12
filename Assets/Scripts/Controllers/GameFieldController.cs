using System.Collections;
using UnityEngine;
using Buginator.Utils;

namespace Buginator.Game
{
    public class GameFieldController : Singleton<GameFieldController>
    {
        [SerializeField]
        private Spawner _spawner;

        // Use this for initialization
        void Start()
        {
            GameController.Instance.OnStartGame += InitField;
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void InitField(int levelNum)
        {
            var settings = Controllers.Settings.Instance.GetLevel(levelNum);
            StartCoroutine(_spawner.StartSpawn(settings));
        }

        private void ClearField()
        {

        }
    }
}