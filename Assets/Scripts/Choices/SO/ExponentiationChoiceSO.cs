using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ExponentiationChoice", menuName = "Choices/ExponentiationChoice", order = 5)]
public class ExponentiationChoiceSO : ChoiceSO
{
    [SerializeField] private int _powerModifier;
    private ScoreManager _scoreManager;

    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = _powerModifier;
        return "^" + Number;
    }

    public override void DoChoice()
    {
        Debug.Log(Number);
        _scoreManager.RaiseScoreToThePower(Number);
    }
}
