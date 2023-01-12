using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Buginator.Utils;
using Buginator.Game;

namespace Buginator.UI
{
    public class UIManager : Singleton<UIManager>
    {
        [Header("Main UI")]
        [SerializeField]
        private MainUIPresenter _mainUI;

        [Header("Game UI")]
        [SerializeField]
        private GameUIPresenter _gameUI;

        #region UnityMEFs

        protected override void Awake()
        {
            base.Awake();
            ShowMainUI();
            _mainUI.OnStartGame += StartGame;
        }

        #endregion

        #region MEFs

        private void ShowMainUI()
        {
            _gameUI.Hide();
            _mainUI.Show();
        }

        private void ShowGameUI()
        {
            _mainUI.Hide();
            _gameUI.Show();
        }

        private void StartGame()
        {
            ShowGameUI();
            GameController.Instance.StartGame();
        }

        #endregion
    }
}
