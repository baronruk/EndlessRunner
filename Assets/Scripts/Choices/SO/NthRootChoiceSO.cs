using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NthRootChoice", menuName = "Choices/NthRootChoice", order = 6)]
public class NthRootChoiceSO : ChoiceSO
{
    private ScoreManager _scoreManager;

    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public override string ShowChoice()
    {
        Number = 2;
        return "√" + Number;
    }

    public override void DoChoice()
    {
        _scoreManager.SquareRootOfScore();
    }
}
