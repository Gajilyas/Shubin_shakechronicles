using UnityEngine;

namespace Assets.Core.Runtime.Ui_Modules
{
    [DisallowMultipleComponent]
    public class CloseApplicationButtonAction : ButtonAction
    {
        protected override void Action()
        {
            base.Action();

            Application.Quit();
        }
    }
}
