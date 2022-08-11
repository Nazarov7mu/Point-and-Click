using Player;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class SpeedManager : MonoBehaviour
    {
        [SerializeField] private PlayerMovement _playerMovement;
    
        [Header("Buttons")]
        [SerializeField] private Button _decreaseButton;
        [SerializeField] private Button _increaseButton;

        private void Awake()
        {
            AssignButtons();
        }

        private void AssignButtons()
        {
            _decreaseButton.onClick.AddListener(()=> _playerMovement.ChangeSpeed(-1));
            _increaseButton.onClick.AddListener(()=> _playerMovement.ChangeSpeed(1));
        }
    }
}