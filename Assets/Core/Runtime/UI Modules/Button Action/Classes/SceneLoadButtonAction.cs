using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Core.Runtime.Ui_Modules
{
    [DisallowMultipleComponent]
    public class SceneLoadButtonAction : ButtonAction
    {
        [SerializeField]
        private string sceneName;

        protected override void Action()
        {
            base.Action();
            OnBeforeAction?.Invoke();
            SceneManager.LoadScene(sceneName);
            OnAfterAction?.Invoke();
        }
    }
}