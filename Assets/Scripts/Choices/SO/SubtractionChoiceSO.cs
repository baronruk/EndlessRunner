using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SubtractionChoice", menuName = "Choices/SubtractionChoice", order = 2)]
public class SubtractionChoiceSO : ChoiceSO
{
    [SerializeField] private int _minSubtractionModifier;
    [SerializeField] private int _maxSubtractionModifier;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = Random.Range(_minSubtractionModifier, _maxSubtractionModifier);
        Debug.Log("Minus " + Number);
        return "-" + Number;
    }

    public override void DoChoice()
    {
        _scoreManager.DecreaseScoreBy(Number);
    }
}
