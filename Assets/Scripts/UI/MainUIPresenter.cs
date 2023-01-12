using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Buginator.UI
{
    public class MainUIPresenter : MonoBehaviour
    {
        internal event Action OnStartGame;

        [SerializeField]
        private Canvas _canvas;
        [SerializeField]
        private Text _currentLevel;
        [SerializeField]
        private Button _startBtn;

        #region UnityMEFs

        private void Awake()
        {
            _startBtn.onClick.AddListener(StartGame);
            Controllers.Settings.Instance.OnLevelLoaded += SetupLevel;
        }

        #endregion

        #region MEFs

        internal void Show()
        {
            _canvas.gameObject.SetActive(true);
        }

        internal void Hide()
        {
            _canvas.gameObject.SetActive(false);
        }

        private void StartGame()
        {
            OnStartGame?.Invoke();
        }

        private void SetupLevel(int level)
        {
            _currentLevel.text = string.Format("Level {0}", level);
        }

        #endregion
    }
}
