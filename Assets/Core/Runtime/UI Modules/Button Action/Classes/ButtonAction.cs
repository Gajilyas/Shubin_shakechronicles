using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Core.Runtime.Ui_Modules
{
    [RequireComponent(typeof(Button))]
    public abstract class ButtonAction : MonoBehaviour
    {
        //Stored required components
        private Button button;

        protected virtual void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(Action);
        }

        protected virtual void Action() {   }

        #region [Callbacks]
        public Action OnBeforeAction;
        public Action OnAfterAction;
        #endregion
    }
}
