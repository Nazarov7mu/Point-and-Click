using System;
using Managers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Collectible
{
    public class CollectiblesSpawner : MonoBehaviour
    {
        [SerializeField] private ScoreManager _scoreManager;
    
        [Header("Prefabs")]
        [SerializeField] private Collectible _collectiblePrefab;

        private GameObject _player;
    
        // To spawn only within this range in playing field
        private const float RangeY = 3.5f;
        private const float RangeX = 2.5f;

        private const float MinDistance = 1.5f;

        private void Awake()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
        }

        private void Start()
        {
            SpawnCollectible();
        }
        
        public void SpawnCollectible()
        {
            float posX, posY, dist;
            GetRandomPosition();
            
            while (dist < MinDistance)
            {
                GetRandomPosition();
                print("Collectible is too close");
            }

            void GetRandomPosition()
            {
                posX = Random.Range(-RangeX, RangeX);
                posY = Random.Range(-RangeY, RangeY);

                dist = Vector3.Distance(new Vector3(posX, posY, 0), _player.transform.position);
            }
            
            Collectible collectible = Instantiate(_collectiblePrefab, new Vector2(posX, posY), Quaternion.identity);
            collectible.Init(this, _scoreManager);
        }

    }
}