using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Operation {
    Add, Subtract, Multiply, Divide, Exponent
}

public abstract class ChoiceSO : ScriptableObject, IChoice
{
    public Color GateColor;
    
    public int Number;

    public Operation Operation;
    
    public abstract string ShowChoice();

    public abstract void DoChoice();

}
