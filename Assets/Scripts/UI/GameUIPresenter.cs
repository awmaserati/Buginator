using UnityEngine;
using UnityEngine.UI;

namespace Buginator.UI
{
    public class GameUIPresenter : MonoBehaviour
    {
        [SerializeField]
        private Canvas _canvas;
        [SerializeField]
        private Text _bugsCount;

        #region MEFs

        internal void Show()
        {
            _canvas.gameObject.SetActive(true);
        }

        internal void Hide()
        {
            _canvas.gameObject.SetActive(false);
        }

        #endregion
    }
}
