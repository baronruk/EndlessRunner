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
            case Operation.Root:
                _scoreManager.SquareRootOfScore();
                break;
        }
    }

    public ChoiceSO GetRandomChoice() 
    {
        /*
            this function assumes that _choice[] has this exact order
            _choice = [ 
                AddChoice,
                SubtractionChoice,
                MultiplicationChoice,
                DivisionChoice,
                ExponentiationChoice
                NthRootChoice,
            ]
        */
        int _selector = Random.Range(0, 1000);
        if (_selector>=0 && _selector<300) {
            return _choices[0];
        } else if (_selector>=300 && _selector<600) {
            return _choices[1];
        } else if (_selector>=600 && _selector<775) {
            return _choices[2];
        } else if (_selector>=775 && _selector<950) {
            return _choices[3];
        } else if (_selector>=950 && _selector<975) {
            return _choices[4];
        } else {
            return _choices[5];
        }
    }
}
