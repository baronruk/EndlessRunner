using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _coinsToSpawn = 5; 
    private GameObject _player;
    private float _startingPoint;

    void OnEnable() {
        _player = GameObject.FindGameObjectWithTag("Player");
        _startingPoint = _player.transform.position.z;
    }

    void Start()
    {
        SpawnCoins(_player);
    }

    void Update() {
        if (Mathf.Abs(_startingPoint-_player.transform.position.z) >= 75)
        {
            _startingPoint = _player.transform.position.z;
            SpawnCoins(_player);
        }
    }
    
    public void SpawnCoins(GameObject gameObject)
    {
        for (int i = 0; i < (Random.Range(0,_coinsToSpawn+1)); i++) {
            GameObject temp = Instantiate(_coinPrefab);
            temp.transform.position = _getRandomPoint(gameObject);
        }
    }

    private Vector3 _getRandomPoint(GameObject gameObject)
    {
        Vector3 point = new Vector3(
            Random.Range(-4.75f, 4.75f),
            gameObject.transform.position.y,
            Random.Range(gameObject.transform.position.z + 5,  gameObject.transform.position.z + 50)
        );
        return point;
    }
}
