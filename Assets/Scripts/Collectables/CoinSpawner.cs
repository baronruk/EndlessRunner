using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _coinsToSpawn = 10; 
    
    void Start()
    {
        SpawnCoins();
    }

    void Update()
    {
        
    }
    
    public void SpawnCoins()
    {
        for (int i = 0; i < _coinsToSpawn; i++) {
            GameObject temp = Instantiate(_coinPrefab);
            temp.transform.position = _getRandomPointInCollider(GetComponent<Collider>());
        }
    }

    private Vector3 _getRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );
        
        if (point != collider.ClosestPoint(point)) {
            point = _getRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
