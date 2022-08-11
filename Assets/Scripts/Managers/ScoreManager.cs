using TMPro;
using UnityEngine;

namespace Managers
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _collectibleAmount;

        private int _amount;
    
        public void IncreaseCollectibles(int value)
        {
            _amount += value;
            UpdateText();
        }

        private void Awake()
        {
            UpdateText();
        }

        private void UpdateText()
        {
            _collectibleAmount.text = $"{_amount}";
        }
    }
}