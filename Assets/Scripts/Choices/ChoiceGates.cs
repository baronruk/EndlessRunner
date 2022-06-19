using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChoiceGates : MonoBehaviour
{
    [SerializeField] private TMP_Text _choiceText;
    [SerializeField] private ChoiceSO _choice;
    [SerializeField] private float _distanceToNextGate = 50f;
    private ChoiceManager _choiceManager;
    private int _totalGatesPairs;
    private Operation _operation;
    private float _number;

    void OnEnable()
    {
        _choiceManager = FindObjectOfType<ChoiceManager>();
        _choice = _choiceManager.GetRandomChoice();
        GetComponent<Renderer>().materials[0].color = _choice.GateColor;
        _choiceText.text = _choice.ShowChoice();
        _operation = _choice.Operation;
        _number = _choice.Number;
        _totalGatesPairs = (FindObjectsOfType<ChoiceGates>().Length)/2;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _choiceManager.checkPlayerChoice(_operation, _number);
            transform.parent.position = _newGatePosition();
        }
    }

    private Vector3 _newGatePosition() {
        float totalDistance = _totalGatesPairs*_distanceToNextGate;
        return new Vector3(transform.parent.position.x, transform.parent.position.y, transform.parent.position.z + totalDistance);
    }
}
