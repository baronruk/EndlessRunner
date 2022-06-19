using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText;
    private float _playerScore;
    
    void OnEnable()
    {
        _playerScore = 0;
    }
    
    public void IncreaseScoreBy(float number) 
    {
        _playerScore+= number;
        _updatePlayerScore();
    }

    public void DecreaseScoreBy(float number) 
    {
        _playerScore-= number;
        _updatePlayerScore();
    }

    public void MultiplyScoreBy(float number) 
    {
        _playerScore= _playerScore*number;
        _updatePlayerScore();
    }

    public void DivideScoreBy(float number) 
    {
        _playerScore= _playerScore/number;
        _updatePlayerScore();
    }

    private void _updatePlayerScore() 
    {
        string _message = " Score: " + _playerScore.ToString();
        _playerScoreText.SetText(_message);
    }
}
