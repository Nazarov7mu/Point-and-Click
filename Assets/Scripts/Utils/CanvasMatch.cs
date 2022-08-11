using UnityEngine;
using UnityEngine.UI;

namespace Utils
{
    // UI elements like buttons and Score number will change their sizes depending on resolution.
    public class CanvasMatch : MonoBehaviour
    {
        [SerializeField] private CanvasScaler[] _canvasScalers;

        private float _defaultAspect = 9f / 16f;
        
        private void Awake()
        {
            var currentAspect = (float) Screen.width / Screen.height;
            
            if (currentAspect > _defaultAspect)
                ChangeScale(1);
            else if(currentAspect < _defaultAspect)
                ChangeScale(0);

            Canvas.ForceUpdateCanvases();
            
            void ChangeScale(float value)
            {
                foreach (var canvasScaler in _canvasScalers)
                {
                    canvasScaler.matchWidthOrHeight = value;
                }
            }
        }
    }
}