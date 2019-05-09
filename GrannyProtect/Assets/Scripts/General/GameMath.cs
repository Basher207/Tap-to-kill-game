using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameMath {

    public static float ToXDecimalFigures (this float number, int decimalFigures) {
        int multi = (int)Mathf.Pow(10, decimalFigures);
        return (Mathf.Round(number * multi)) / multi;
    }
}
