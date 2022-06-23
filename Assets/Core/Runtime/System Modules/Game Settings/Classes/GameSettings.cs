using System;
using UnityEngine;

namespace Assets.Core.Runtime.System_Modules
{
    [CreateAssetMenu(fileName = "Game Settings", menuName = "Snake Chronicles/System Modules/Game Settings")]
    public class GameSettings : ScriptableObject
    {
        [Header("Sound")]
        [SerializeField]
        [Range(0,1)]
        private float dialogVolume;

        [SerializeField]
        [Range(0, 1)]
        private float musicVolume;

        [SerializeField]
        [Range(0, 1)]
        private float effectVolume;

        [Header("Video")]
        [SerializeField]
        private Vector2 resolution;

        #region [Getter / Setter]
        public float GetDialogVolume()
        {
            return dialogVolume;
        }

        public void SetDialogVolume(float value)
        {
            dialogVolume = value;
            OnChangeVolumeSettings?.Invoke();
        }

        public float GetMusicVolume()
        {
            return musicVolume;
        }

        public void SetMusicVolume(float value)
        {
            musicVolume = value;
            OnChangeVolumeSettings?.Invoke();
        }

        public float GetEffectVolume()
        {
            return effectVolume;
        }

        public void SetEffectVolume(float value)
        {
            effectVolume = value;
            OnChangeVolumeSettings?.Invoke();
        }
        #endregion

        #region [Callbacks]
        public Action OnChangeVolumeSettings; 
        #endregion
    }
}
