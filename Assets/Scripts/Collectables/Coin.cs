using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _turnSpeed = 90f;
    [SerializeField] private float _coinValue = 0.5f;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }
    
    void Update()
    {
        _coinAnimation();
    }
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Player") {
            _scoreManager.IncreaseScoreBy(_coinValue);
        }
        Destroy(gameObject);
    }

    private void _coinAnimation() 
    {
        transform.Rotate(0, 0, _turnSpeed * Time.deltaTime);
    }
}
