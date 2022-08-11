using Managers;
using UnityEngine;

namespace Collectible
{
    public class Collectible : MonoBehaviour
    {
        // In the future, there might be Collectibles with different scores.
        [SerializeField] private int _score = 1;

        private CollectiblesSpawner _collectiblesSpawner;
        private ScoreManager _scoreManager;
    
        public void Init(CollectiblesSpawner collectiblesSpawner, ScoreManager scoreManager)
        {
            _scoreManager = scoreManager;
            _collectiblesSpawner = collectiblesSpawner;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                _scoreManager.IncreaseCollectibles(_score);
                _collectiblesSpawner.SpawnCollectible();
                Destroy(gameObject);
            }
        }
    }
}