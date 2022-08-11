using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectiblesSpawner : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager;
    
    [Header("Prefabs")]
    [SerializeField] private Collectible _collectiblePrefab;
    
    // To spawn only within this range in playing field
    private const float RangeY = 3.5f;
    private const float RangeX = 2.5f;
    
    public void SpawnCollectible()
    {
        float posX = Random.Range(-RangeX, RangeX);
        float posY = Random.Range(-RangeY, RangeY);
        
        Collectible collectible = Instantiate(_collectiblePrefab, new Vector2(posX, posY), Quaternion.identity);
        collectible.Init(this, _scoreManager);
    }

    private void Start()
    {
        SpawnCollectible();
    }
}