using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MultiplicationChoice", menuName = "Choices/MultiplicationChoice", order = 3)]
public class MultiplicationChoiceSO : ChoiceSO
{
    [SerializeField] private int _minMultiplicationModifier;
    [SerializeField] private int _maxMultiplicationModifier;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = Random.Range(_minMultiplicationModifier, _maxMultiplicationModifier);
        return "x" + Number;
    }

    public override void DoChoice()
    {
        _scoreManager.MultiplyScoreBy(Number);
    }
}
