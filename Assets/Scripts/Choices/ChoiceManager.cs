using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    [SerializeField] private ChoiceSO[] _choices;
    private ScoreManager _scoreManager;
    
    void OnEnable()
    {
       _scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void checkPlayerChoice(Operation operation, float number)
    {
        switch(operation)
        {
            case Operation.Add:
                _scoreManager.IncreaseScoreBy(number);
                break;
            case Operation.Subtract:
                _scoreManager.DecreaseScoreBy(number);
                break;
            case Operation.Multiply:
                _scoreManager.MultiplyScoreBy(number);
                break; 
            case Operation.Divide:
                _scoreManager.DivideScoreBy(number);
                break;  
            case Operation.Exponent:
                _scoreManager.RaiseScoreToThePower(number);
                break;
        }
    }

    public ChoiceSO GetRandomChoice() 
    {
        return _choices[Random.Range(0, _choices.Length)];
    }
}
