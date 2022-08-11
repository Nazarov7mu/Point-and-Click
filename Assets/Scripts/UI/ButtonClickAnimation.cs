using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class ButtonClickAnimation : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private Vector3 _initScale;
        private Vector3 _smallScale;

        private float _minScale = 0.90f;

        public void OnPointerDown(PointerEventData eventData)
        {
            transform.localScale = _smallScale;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            transform.localScale = _initScale;
        }

        private void Awake()
        {
            _initScale = transform.localScale;
            _smallScale = _initScale * _minScale;
        }
    }
}