using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AddChoice", menuName = "Choices/AddChoice", order = 1)]
public class AddChoiceSO : ChoiceSO
{
    [SerializeField] private int _minAddModifier;
    [SerializeField] private int _maxAddModifier;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = Random.Range(_minAddModifier, _maxAddModifier);
        return "+" + Number;
    }

    public override void DoChoice()
    {
        Debug.Log(Number);
        _scoreManager.IncreaseScoreBy(Number);
    }

}
