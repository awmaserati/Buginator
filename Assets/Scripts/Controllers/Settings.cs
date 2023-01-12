using System;
using UnityEngine;
using Buginator.Utils;
using Buginator.Settings;

namespace Buginator.Controllers
{
    public class Settings : Singleton<Settings>
    {
        private const string LEVEL = "current_level";

        public event Action<int> OnLevelLoaded;

        [SerializeField]
        private GlobalSettingsSO _globalSettings;

        #region UnityMEFs

        private void Start()
        {
            Load();
        }

        #endregion

        #region MEFs

        internal void Load()
        {
            if (PlayerPrefs.HasKey(LEVEL))
            {
                OnLevelLoaded?.Invoke(PlayerPrefs.GetInt(LEVEL));
                return;
            }

            OnLevelLoaded?.Invoke(1);
            Save(1);
        }

        internal void Save(int level)
        {
            PlayerPrefs.SetInt(LEVEL, level);
        }

        internal LevelSettingsSO GetLevel(int levelNum)
        {
            return _globalSettings.GetLevel(levelNum);
        }

        #endregion
    }
}