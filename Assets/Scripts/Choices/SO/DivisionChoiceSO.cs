using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DivisionChoice", menuName = "Choices/DivisionChoice", order = 4)]
public class DivisionChoiceSO : ChoiceSO
{
    [SerializeField] private int _minDivisionModifier;
    [SerializeField] private int _maxDivisionModifier;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = Random.Range(_minDivisionModifier, _maxDivisionModifier);
        return "/" + Number;
    }

    public override void DoChoice()
    {
        _scoreManager.DivideScoreBy(Number);
    }
}
