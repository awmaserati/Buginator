using System;
using UnityEngine;
using Buginator.Utils;

namespace Buginator.Game
{
    public class GameController : Singleton<GameController>
    {
        internal event Action<int> OnStartGame;
        internal event Action OnLoseGame;
        internal event Action OnWinGame;

        private int _currentLevel;

        protected void Start()
        {
            Controllers.Settings.Instance.OnLevelLoaded += GetLevel;
        }

        #region MEFs

        internal void StartGame()
        {
            OnStartGame?.Invoke(_currentLevel);
        }

        private void GetLevel(int levelNum)
        {
            _currentLevel = levelNum;
        }

        #endregion
    }
}